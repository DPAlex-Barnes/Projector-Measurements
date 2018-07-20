using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;


namespace Projector_Measurements
{
    public partial class Form1 : Form
    {
        char[] receptor = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] command54 = { '5', '4', '1', ' ', ' ', ' ' };
        char[] command55 = { '5', '5', '0', ' ', ' ', '1' };
        char[] command10 = { '1', '0', '0', '2', '0', '1' };
        

        SerialPort port;
        string[] comms = SerialPort.GetPortNames();
        double Wuxga = 4.56;
        double[] ninePoint = new double[9] { 699, 663, 668, 513, 595, 559, 673, 529, 541 };
        string[] lxData = new string[9] { "+ 3485","+23455","+54365","+23435","+   55","+   65","+ 6545","+45655","+  235"};
        


        public Form1()
        {
            InitializeComponent();
            ComboBoxComms.Items.AddRange(comms);
            


        }
        #region get lumens button click

        private void button1_Click(object sender, EventArgs e)
        {
            ninePoint = ProcessData(lxData);
       
            string reading = Convert.ToString(Calculations.Lumens(ninePoint, Wuxga));
            TopLeft.Text = Convert.ToString(ninePoint[0]);
            Top.Text = Convert.ToString(ninePoint[1]);
            TopRight.Text = Convert.ToString(ninePoint[2]);
            Left.Text = Convert.ToString(ninePoint[3]);
            Centre.Text = Convert.ToString(ninePoint[4]);
            Right.Text = Convert.ToString(ninePoint[5]);
            BottomLeft.Text = Convert.ToString(ninePoint[6]);
            Bottom.Text = Convert.ToString(ninePoint[7]);
            BottomRight.Text = Convert.ToString(ninePoint[8]);
            
            LumensRead.Text = reading;
      
        }

        #endregion

        #region Serial connect button click

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            var item = (string)ComboBoxComms.SelectedItem;

            byte[] bytestosend = sendCommand(command54, receptor[0], receptor[0]);
            bool isConnected = false;
            try
            {
                port = new SerialPort(item, 9600, Parity.Even, 7, StopBits.One);
                port.Open();
                port.Write(bytestosend, 0, bytestosend.Length);

                isConnected = true;
                label1.Text = port.ReadLine();

            }
            catch (Exception)
            {
                label1.Text = "No Connection";
            }

            if (isConnected)
            {
                var read = Task.Run(() =>
                {
                    port.Write(sendCommand(command55, receptor[9], receptor[9]), 0, 14);
                    Thread.Sleep(80);

                    for (int i = 1; i <= 9; i++)
                    {
                        port.Write(sendCommand(command10, receptor[0], receptor[i]), 0, 14);
                        Thread.Sleep(80);
                    }
                    Thread.Sleep(5000);
                    

                    for (int i = 0; i < 9; i++)
                    {
                        port.Write(sendCommand(command10, receptor[0], receptor[i+1]), 0, 14);
                        Console.WriteLine("Result:" + receptor[i+1] + " " + port.ReadLine());
                        lxData[i] = port.ReadLine().Substring(9,6);
                        Thread.Sleep(80);
                    }
                    Invoke(new Action(() =>
                    {
                        label3.Text = "Done";
                    }));

                });
            }
            
        }

        #endregion

        #region Connection functions

        public static char[] Bcc(char[] command, char rec10, char rec1)
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

        public static byte[] sendCommand(char[] command, char rec10, char rec1)
        {
            char[] bcc = Bcc(command, rec10, rec1);

            // Command Constants
            byte STX = 0x02;
            byte ETX = 0x03;
            byte CR = 0x0D;
            byte LF = 0x0A;

            // Converting Char to Byte
            byte[] commandByte = new byte[command.Length];
            byte rec10Byte = (byte)rec10;
            byte rec1Byte = (byte)rec1;

            for (int i = 0; i < command.Length; i++)
            {
                commandByte[i] = (byte)command[i];
            }
                      
            // build complete command
            byte[] complete = { STX, rec10Byte, rec1Byte, 0, 0, 0, 0, 0, 0, ETX,
                (byte)bcc[0], (byte)bcc[1], CR, LF};

            for (int i = 0; i< commandByte.Length; i++)
            {
                
                complete[i + 3] = commandByte[i];

            }

            return complete;
        }


        #endregion

        public static double[] ProcessData(string[] data)
        {
            double compensationFactor = 1.05;
            double[] multipliers = { Math.Pow(10,-4), Math.Pow(10, -3), Math.Pow(10, -2), Math.Pow(10, -1), Math.Pow(10, 0),
                Math.Pow(10, 1), Math.Pow(10, 2), Math.Pow(10, 3), Math.Pow(10, 4), Math.Pow(10, 5) };
            double[] processed = new double[9];
            int multiplierIndex = int.Parse(data[0][data[0].Length-1].ToString());
            
            for (int i = 0; i < data.Length; i++)
            {
                string s = data[i];
                if (s.StartsWith("+"))
                {
                    data[i] = s.Substring(1,4);
                    data[i] = data[i].Trim();
                    processed[i] = double.Parse(data[i]);

                }
                else if (s.StartsWith("-"))
                {
                    data[i] = s.Substring(1,4);
                    data[i] = data[i].Trim();
                    processed[i] = double.Parse(data[i]);
                }                        
               
            }

            foreach (double point in processed)
            {
                processed[Array.IndexOf(processed, point)] = (point * multipliers[multiplierIndex])* compensationFactor;
            }

            return processed;



        }
            
        
    }

  

}
