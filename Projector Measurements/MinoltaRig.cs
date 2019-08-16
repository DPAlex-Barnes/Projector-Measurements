using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    public class MinoltaRig
    {
        
        SerialPort port;
        /// <summary>
        /// gets available com ports.
        /// </summary>

        // Constant bytes to send.
        private const byte STX = 0x02;
        private const byte ETX = 0x03;
        private const byte CR = 0x0D;
        private const byte LF = 0x0A;

        // single character for the receptor array.
        private char[] receptor = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        // command54 sets Minolta to PC mode, Minolta replies.
        private char[] command54 = { '5', '4', '1', ' ', ' ', ' ' };
        // command55 sets all Minolta receptors to Run
        private char[] command55 = { '5', '5', '0', ' ', ' ', '1' };
        // command10 asks the minolta for some measured data
        private char[] command10 = { '1', '0', '0', '2', '0', '1' };


        private string[] ninePointLuxData = new string[9];
        private string[] cornerLuxData = new string[4];
        private bool isConnected = false;

        /// <summary>
        /// Initialise connection to Minolta
        /// </summary>
        /// <param name="CommPort">
        /// the comm port connected to Minolta
        /// </param>
        /// <returns>
        /// bool true if connection established
        /// </returns>
        public bool Initialise(string CommPort)
        {
            byte[] bytestosend = sendCommand(command54, receptor[0], receptor[0]);
            
            try
            {
                port = new SerialPort(CommPort, 9600, Parity.Even, 7, StopBits.One);
                port.ReadTimeout = 2000;
                port.Open();
                port.Write(bytestosend, 0, bytestosend.Length);
                

             // checks response of Minolta should be .0054    .02..
                if (port.ReadLine().Contains("0054    02"))
                {
                    isConnected = true;
                }              
            }
            catch (Exception)
            {
                isConnected = false;
            }

            return isConnected;
        }

        /// <summary>
        /// Sets the Minolta to start reading
        /// </summary>
        /// <returns>
        /// bool true if successful
        /// </returns>

        public bool Start()
        {
            bool isComplete = false;
            // starts reading on a new thread
            var t = Task.Run(() =>
            {
                port.Write(sendCommand(command55, receptor[9], receptor[9]), 0, 14);
                Thread.Sleep(100);

                for (int i = 1; i <= 9; i++)
                {
                    port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                    Thread.Sleep(100);     
                }

                for (int i = 0; i < 4; i++)
                {
                    port.Write(sendCommand(command10, receptor[1], receptor[i]), 0, 14);
                    Thread.Sleep(100);
                }
                
                //Thread.Sleep(5000);
                
            });
            t.Wait();
            isComplete = t.IsCompleted;
            return isComplete;
        }


        /// <summary>
        /// Reads the centre 9 point array
        /// </summary>
        /// <returns>
        /// a string array of the illuminence data
        /// </returns>
        public string[] ReadNine()
        {
            Thread.Sleep(100);
            for (int i = 1; i <= 9; i++)
            {
                try
                {
                    port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                    ninePointLuxData[i-1] = port.ReadLine().Substring(9, 6);
                    Console.WriteLine(ninePointLuxData[i-1]);
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                 
            }
                                        
            return ninePointLuxData;
        }

        /// <summary>
        /// Reads the 4 corner points of the array
        /// </summary>
        /// <returns>
        /// a string array of the illuminence data
        /// </returns>
        public string[] ReadCorners()
        {
            Thread.Sleep(100);
            for (int i = 0; i < 4; i++)
            {
                try
                {                        
                    port.Write(sendCommand(command10, receptor[1], receptor[i]), 0, 14);
                    cornerLuxData[i] = port.ReadLine().Substring(9, 6);
                    Console.WriteLine(cornerLuxData[i]);
                    Thread.Sleep(80);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
      
            }

            return cornerLuxData;
        }

        #region Creating command to send to the Minolta

        /*
         * |   STX   |  Rec  |  Rec  | Command | Command |               Data                |   ETX   |   BCC   |  BCC   |   CR   |   LF   |
         * |         |   10  |   1   |    10   |    1    |                4                  |         |    10   |   1    |        |        |
         * |---------|-------|-------|---------|---------|--------|--------|--------|--------|---------|---------|--------|--------|--------|
         * |   0x02  |  '0'  |  '0'  |   '5'   |   '4'   |   ' '  |   ' '  |   '  ' |   ' '  |   0x03  |   '1'   |  '3'   |  0x0D  |  0x0A  |
         * |         |       |       |         |         |        |        |        |        |         |         |        |        |        |
         */

        private byte[] sendCommand(char[] command, char rec10, char rec1)
        {
            char[] bcc = CalcBcc(command, rec10, rec1);
            byte[] commandByte = toByteArray(command);

            // build complete command
            byte[] complete = { STX, (byte)rec10, (byte)rec1, 0, 0, 0, 0, 0, 0, ETX,
                (byte)bcc[0], (byte)bcc[1], CR, LF};

            for (int i = 0; i < commandByte.Length; i++)
            {
                complete[i + 3] = commandByte[i];
            }

            return complete;
        }

        // Checksum(Block Character Check(BCC)) (xor up to ETX but not including STX)
        private char[] CalcBcc(char[] command, char rec10, char rec1)
        {

            int bcc = rec10;
            bcc ^= rec1;
            foreach (char item in command)
            {
                bcc ^= item;
            }
            bcc ^= 0x03;

            string s = bcc.ToString("x2");
            var array = s.Split();

            return s.ToCharArray();
        }      

        private byte[] toByteArray(char[] sArray)
        {
            byte[] bArray = new byte[sArray.Length];
            
            for (int i = 0; i < sArray.Length; i++)
            {
                bArray[i] = (byte)sArray[i];
            }
            return bArray;
        }

        #endregion
        
    }
}



        
    

    

