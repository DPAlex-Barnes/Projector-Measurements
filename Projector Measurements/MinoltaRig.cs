using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    public class MinoltaRig
    {
        SerialPort port;
        public string[] comms = SerialPort.GetPortNames();

        private const byte STX = 0x02;
        private const byte ETX = 0x03;
        private const byte CR = 0x0D;
        private const byte LF = 0x0A;

        private char[] receptor = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] command54 = { '5', '4', '1', ' ', ' ', ' ' };
        private char[] command55 = { '5', '5', '0', ' ', ' ', '1' };
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
        /// a true or false if a connection is established
        /// </returns>
        public bool Initialise(string CommPort)
        {
            byte[] bytestosend = sendCommand(command54, receptor[0], receptor[0]);
            
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
            var t = Task.Run(() =>
            {
                port.Write(sendCommand(command55, receptor[9], receptor[9]), 0, 14);
                Thread.Sleep(80);

                for (int i = 1; i <= 9; i++)
                {
                    port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                    Thread.Sleep(80);     
                }

                for (int i = 0; i < 4; i++)
                {
                    port.Write(sendCommand(command10, receptor[1], receptor[i]), 0, 14);
                    Thread.Sleep(80);
                }
                
                Thread.Sleep(5000);
                
            });
            t.Wait();
            isComplete = t.IsCompleted;
            return isComplete;
        }

        public string[] ReadNine()
        {
            bool isRunning = true;
            
            var t = Task.Run(() =>
            {
                Thread.Sleep(600);
                for (int i = 1; i <= 9; i++)
                {
                    try
                    {
                        
                        port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                        ninePointLuxData[i-1] = port.ReadLine().Substring(9, 6);
                        Thread.Sleep(80);
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }
                
                isRunning = false;                           
            });

            t.Wait();
            isRunning = t.IsCompleted;

            return ninePointLuxData;
        }

        public string[] ReadCorners()
        {
            bool isRunning = true;

            var t = Task.Run(() =>
            {
                Thread.Sleep(600);
                for (int i = 0; i < 4; i++)
                {
                    try
                    {                        
                        port.Write(sendCommand(command10, receptor[1], receptor[i]), 0, 14);
                        cornerLuxData[i] = port.ReadLine().Substring(9, 6);
                        Thread.Sleep(80);
                    }
                    catch (Exception)
                    {
                        
                    }

                }
                
                
            });

            t.Wait();
            isRunning = t.IsCompleted;
            return cornerLuxData;
        }

        #region Creating command to send to the Minolta

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



        
    

    

