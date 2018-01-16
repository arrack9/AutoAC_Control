using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAC_Control
{
    class ComPort : SerialPort 
    {
        string RCommand;

        public delegate void DelegateDefine(String MyPara);
        string cmdACON = "!0100000000FF";
        string cmdACOFF = "!0200000000FE";
        string cmdLDR1 = "!0312345678E9";
        string cmdLDR2 = "!0312345678E9";//"!0300000200FD";
        string cmdLDR3 = "!0312345678E9";//"!0300000300FD";
        string cmdLDR4 = "!0312345678E9";//"!0300000400F9";
        //string cmdMNTON = "!0300000000FD";
       
        public ComPort()
        {

        }
        

        public ComPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits)
        {
            PortName = portName;
            BaudRate = baudRate;
            Parity = parity;
            StopBits = stopBits;
        }

        public string RcmdLDR(int LDR)
        {
            switch (LDR)
            {
                case 1:
                    WriteLine(cmdLDR1);
                    break;
                case 2:
                    WriteLine(cmdLDR2);
                    break;
                case 3:
                    WriteLine(cmdLDR3);
                    break;
                case 4:
                    WriteLine(cmdLDR4);
                    break;
            }
            RCommand = ReadLine();
            return RCommand;
        }

        public void Wcmd_ACON()
        {
            WriteLine(cmdACON);
        }

        public void Wcmd_ACOFF()
        {
            WriteLine(cmdACOFF);
        }

        public void AutonACSwitch(bool isACON)
        {
            if (isACON)
            {
                 WriteLine(cmdACON);
            }
            else
            {            
                WriteLine(cmdACOFF); 
            }
        }

        public string AutoReceived()
        {
            Thread.Sleep(1);
            RCommand = this.ReadLine();
            return RCommand;  
        }

        public void ClearBuff()
        {
            DiscardInBuffer();       // RX
            DiscardOutBuffer();      // TX   
        }

    }
}
