using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class MinoltaRig
    {
        SerialPort port;
        public string[] comms = SerialPort.GetPortNames();
        private char[] receptor = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] command54 = { '5', '4', '1', ' ', ' ', ' ' };
        private char[] command55 = { '5', '5', '0', ' ', ' ', '1' };
        private char[] command10 = { '1', '0', '0', '2', '0', '1' };

        public bool Initialise(string CommPort)
        {


            byte[] bytestosend = sendCommand(command54, receptor[0], receptor[0]);
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
                port.Write(sendCommand(command55, receptor[9], receptor[9]), 0, 14);
                Thread.Sleep(80);

                for (int i = 1; i <= 9; i++)
                {
                    port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                    Thread.Sleep(80);
                    
                }
                Thread.Sleep(5000);
                isComplete = true;
            });
            while (!isComplete)
            {
                
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
                for (int i = 0; i < 9; i++)
                {
                    port.Write(sendCommand(command10, receptor[0], receptor[i + 1]), 0, 14);
                    Console.WriteLine("Result:" + receptor[i + 1] + " " + port.ReadLine());
                    lxData[i] = port.ReadLine().Substring(9, 6);
                    Thread.Sleep(80);
                }
                Thread.Sleep(5000);
                isRunning = false;                           
            });
            while (isRunning)
            {
                
            }

            return lxData;

        }

        #region Creating command to send to the Minolta
        private char[] Bcc(char[] command, char rec10, char rec1)
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

        

        private byte[] sendCommand(char[] command, char rec10, char rec1)
        {
            char[] bcc = Bcc(command, rec10, rec1);

            // Command Constants
            byte STX = 0x02;
            byte ETX = 0x03;
            byte CR = 0x0D;
            byte LF = 0x0A;

            
            byte[] commandByte = toByte(command);

            // build complete command
            byte[] complete = { STX, toByte(rec10), toByte(rec1), 0, 0, 0, 0, 0, 0, ETX,
                (byte)bcc[0], (byte)bcc[1], CR, LF};

            for (int i = 0; i < commandByte.Length; i++)
            {

                complete[i + 3] = commandByte[i];

            }

            return complete;
        }

        private byte[] toByte(char[] sArray)
        {
            byte[] bArray = new byte[sArray.Length];
            
            for (int i = 0; i < sArray.Length; i++)
            {
                bArray[i] = (byte)sArray[i];
            }
            return bArray;
        }

        private byte toByte(char c)
        {

            return (byte)c;
        }

        #endregion

    }
}



        
    

    

