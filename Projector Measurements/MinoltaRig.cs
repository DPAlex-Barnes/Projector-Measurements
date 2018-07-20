using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class MinoltaRig
    {
        SerialPort port;
        private const byte STX = 0x02;
        private const byte ETX = 0x03;
        private const byte CR = 0x0D;
        private const byte LF = 0x0A;

        public string[] comms = SerialPort.GetPortNames();      
    
        private char[] receptor = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] command54 = { '5', '4', '1', ' ', ' ', ' ' };
        private char[] command55 = { '5', '5', '0', ' ', ' ', '1' };
        private char[] command10 = { '1', '0', '0', '2', '0', '1' };

        private byte[] bytestosend;

        public bool Initialise(string CommPort)
        {
            bytestosend = sendCommand(command54, receptor[0], receptor[0]);
            bool isConnected = false;

            try
            {
                port = new SerialPort(CommPort, 9600, Parity.Even, 7, StopBits.One);
                port.Open();
                port.Write(bytestosend, 0, bytestosend.Length);
                
             
                if (port.ReadLine().Contains("0054"))
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

        public bool Start()
        {
            
            bool isComplete = false;
            var set = Task.Run(() =>
            {
                bytestosend = sendCommand(command55, receptor[9], receptor[9]);
                port.Write(bytestosend, 0, bytestosend.Length);
                Thread.Sleep(80);

                for (int i = 1; i <= 9; i++)
                {
                    bytestosend = sendCommand(command10, receptor[0], receptor[i]);
                    port.Write(bytestosend, 0, bytestosend.Length);
                    Thread.Sleep(80);
                    
                }
                Thread.Sleep(5000);
                isComplete = true;
            });
            while (!isComplete)
            {
                // Do Nothing 
            }
            isComplete = true;
            Console.WriteLine(isComplete);
            return isComplete;
        }

        public string[] Read()
        {
            bool isRunning = true;
            string[] lxData = new string[9];
            var read = Task.Run(() =>
            {
                for (int i = 1; i <= lxData.Length; i++)
                {
                    try
                    {
                        bytestosend = sendCommand(command10, receptor[0], receptor[i + 1]);
                        port.Write(bytestosend, 0, bytestosend.Length);
                        Console.WriteLine("Result:" + receptor[i + 1] + " " + port.ReadLine());
                        lxData[i] = port.ReadLine().Substring(9, 6);
                        Thread.Sleep(80);
                    }
                    catch(Exception)
                    {
                        break;
                    }
                }
                Thread.Sleep(5000);
                isRunning = false;                           
            });
            while (isRunning)
            {
                //Do Nothing
            }

            return lxData;
        }

        #region Creating command to send to the Minolta

        private byte[] sendCommand(char[] command, char rec10, char rec1)
        {
            char[] bcc = Bcc(command, rec10, rec1);            
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

        private char[] Bcc(char[] command, char rec10, char rec1)
        {

            int bcc = rec10;
            bcc ^= rec1;
            foreach (char item in command)
            {
                bcc ^= item;
            }
            bcc ^= ETX;

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



        
    

    

