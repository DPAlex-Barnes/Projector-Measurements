using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;


namespace Projector_Measurements
{
    class Projector
    {
        List<string> commands;
        SerialPort projector;
        string baudrate;
        string dataLength;
        string stopBits;
        string parity;
        string flowControl;
        string powerOn;
        string powerOff;
        string shutterOpen;
        string shutterClose;
        string whiteTP;
        string blackTP;
        string redTP;
        string greenTP;
        string blueTP;
        string noTP;

        public void InitialiseCommands(string path, string selectedProtocol)
        {
            setCommands(path + selectedProtocol + ".toast");
            projector = new SerialPort();
            projector.PortName = Properties.Settings.Default.ProjectorComms;
            projector.BaudRate = int.Parse(baudrate);
            projector.DataBits = int.Parse(dataLength);
            projector.StopBits = StopBits.One;
            projector.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            projector.Open();
            
        }

        public void WhiteTP()
        {
            send(whiteTP);
        }

        public void BlackTP()
        {
            send(blackTP);
        }

        public void OpenShutter()
        {
            send(shutterOpen);
        }

        public void CloseShutter()
        {
            send(shutterClose);
        }

        private void setCommands(string protocolFile)
        {
            commands = new List<string>();
            string[] lines = File.ReadAllLines(protocolFile);
            foreach (var line in lines)
            {
                if (line.StartsWith("#") || line.Equals(""))
                {
                    //Do Nothing
                }
                else
                {
                    commands.Add(line);
                }

            }
            

            baudrate = commands[0];
            dataLength = commands[1];
            stopBits = commands[2];
            parity = commands[3];
            flowControl = commands[4];
            powerOn = commands[5];
            powerOff = commands[6];
            shutterOpen = commands[7];
            shutterClose = commands[8];
            whiteTP = commands[9];
            redTP = commands[10];
            greenTP = commands[11];
            blueTP = commands[12];
            blackTP = commands[13];
            noTP = commands[14];
        }

        private void send(string data)
        {
            try
            {
                data = data + "\r";
                Console.WriteLine(data);
                projector.Write(data);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadTo("\r");
        }

    }
}
