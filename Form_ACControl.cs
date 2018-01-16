using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAC_Control
{
    public partial class Form_ACControl : Form
    {
        [DllImport("kernel32")]
        static extern uint GetTickCount();
        [DllImport("winmm")]
        static extern uint timeGetTime();
        [DllImport("winmm")]
        static extern void timeBeginPeriod(int t);
        [DllImport("winmm")]
        static extern void timeEndPeriod(int t);

        ComPort ComPort = new ComPort("COM1", 9600, Parity.None, 8, StopBits.One);
        enum LDR { LDR1 = 1, LDR2 = 2, LDR3 = 3, LDR4 = 4 }
        //string cmdMNTON = "!0300000000FD";
        string[] COMPorts = ComPort.GetPortNames(); //取得存在的COM. 如果存在二個COM則是在COMPorts[0]和COMPorts[1], 以此類推
        DateTime sendOnTime;
        bool isPressStartButton;
        bool isACON;
        bool isTimerInvalid;
        int normalDelayTime;
        int decDelayTime;
        int repeatTime;
        int timeIntervalCounter ;
        int SendDatatCounter;
        static int maxIntValue = 2147483647;  // Set maxIntValue to the maximum value for integers.
        Stopwatch sw = new Stopwatch();
        Thread thd;
        //StreamWriter log = new StreamWriter(@"D:\log.txt", true);    

        private void InitialVariable()
        {
            isPressStartButton = false;
            isACON = false;
            isTimerInvalid = false;
            repeatTime = 1;
            timeIntervalCounter = 1;
            SendDatatCounter = 0;
        }

        private void InitialSerialPort()
        {
            if (COMPorts.Length >= 1)
            {       
                ComPort.PortName = COMPorts[0];                //改變SerialPort的PortName為現存的COM, 因為Default之設定為COM1.  
                comboBox1.Text = COMPorts[0];                  //Combo.Text先Show一個現存的COM.             
                comboBox1.Items.Clear();                       //先將原來在Combo裡頭的內容清掉, 避免重覆寫入       
                foreach (string port in COMPorts) { comboBox1.Items.Add(port); }  //將找到之現有COM加入Combo,Text中.
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComPort.PortName = comboBox1.Text;
            ComPort.Open();
        }
        public Form_ACControl()
        {
            InitialVariable();
            InitializeComponent();
            InitialSerialPort();        
        }

        
        public void WriteMsgToTextBox(string str) //write message to text box
        {
            TBOX_Info.AppendText(str + Environment.NewLine);
            TBOX_Info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        }
        

        public void WriteMsgToText(string str)
        {
            File.AppendAllText(@"D:\log.txt", str);     
        }

        private void CheckPortErrorMsg(InvalidOperationException ex)
        {
            WriteMsgToText(ex.Message);
            MessageBox.Show("Please check your comport, the button control is invaild!!!", "Comport Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void CheckNumErrorMsg(Exception ex)
        {
            WriteMsgToText(ex.Message);
            MessageBox.Show("Please enter the number!!!!!!", "Wrong Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void Btn_LDR1_Click(object sender, EventArgs e)
        {
            try {
                Lbl_LDR1.Text = ComPort.RcmdLDR(Convert.ToInt16(LDR.LDR1));
            }
            catch(InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }

        private void Btn_LDR2_Click(object sender, EventArgs e) 
        {
            try
            {
                Lbl_LDR1.Text = ComPort.RcmdLDR(Convert.ToInt16(LDR.LDR2));
            }
            catch (InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }

        private void Btn_LDR3_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_LDR1.Text = ComPort.RcmdLDR(Convert.ToInt16(LDR.LDR3));
            }
            catch (InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }

        private void Btn_LDR4_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_LDR1.Text = ComPort.RcmdLDR(Convert.ToInt16(LDR.LDR4));
            }
            catch (InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                InitialVariable();
                isPressStartButton = true;
                Btn_All_Lock(true);
                normalDelayTime = Convert.ToInt32(TBox_DelayTime.Text) * 1000;//ms 
                decDelayTime = Convert.ToInt32(TBox_DecDelyTime.Text);
                if (decDelayTime == 0) isTimerInvalid = true;               
                ComPort.DataReceived += new SerialDataReceivedEventHandler(AutoRun_DataReceived);
                if (ComPort.IsOpen == false) ComPort.Open();
                SendDataTimer.Interval = Convert.ToInt32(TBox_DelayTime.Text) * 1000;//ms   
#if timerEvent
                SendDataTimer.Tick += new System.EventHandler(SendDataTimerTick);
#else
                thd = new Thread(new ThreadStart(MsTimeCorrection));
                thd.IsBackground = true;
                thd.Start();
#endif
                SendDataTimer.Enabled = true;
                StartWatchControl();
            }
            catch (Exception ex)
            {
                CheckNumErrorMsg(ex);
            }
        }
        private void Btn_All_Lock(bool btnLock)
        {
            if (btnLock)
            {
                Btn_LDR1.Enabled = false;
                Btn_LDR2.Enabled = false;
                Btn_LDR3.Enabled = false;
                Btn_LDR4.Enabled = false;
                Btn_ACON.Enabled = false;
                Btn_ACOFF.Enabled = false;
                Btn_Start.Enabled = false;
            }
            else
            {
                Btn_LDR1.Enabled = true;
                Btn_LDR2.Enabled = true;
                Btn_LDR3.Enabled = true;
                Btn_LDR4.Enabled = true;
                Btn_ACON.Enabled = true;
                Btn_ACOFF.Enabled = true;
                Btn_Start.Enabled = true;
            }
        }

        private int CheckTimerInterval(bool isACON, int decDelayTime)
        {
            if (isACON == false)
            {
                SendDataTimer.Interval = Convert.ToInt32(TBox_DelayTime.Text) * 1000;
            }
            else
            {
                if ((normalDelayTime > (decDelayTime * timeIntervalCounter)) && (isTimerInvalid == false))
                    SendDataTimer.Interval = normalDelayTime - (decDelayTime * timeIntervalCounter);
                else
                {
                    isTimerInvalid = true;
                    if (thd.IsAlive)
                    {
                        Btn_Start.Invoke(new Action(() => { Btn_All_Lock(false); StopDataReceivedEvent(); }));  //unlocked all button and stop data recervied event                   
                        thd.Abort();
                        thd.Join();
                    }                                               
                }
            }
            return SendDataTimer.Interval + 3;
        }

        private void CheckCounter(int SendDataCounter)
        {
            if (SendDatatCounter < maxIntValue)
                SendDatatCounter++;

            if (SendDatatCounter % 2 == 0)
            {
                sendOnTime = DateTime.Now;
                repeatTime++;
            }
      

            if (repeatTime > Convert.ToInt32(TBox_RepeatTime.Text))
            {
                timeIntervalCounter++;
                repeatTime = 1;
            }
        }

        private void StopDataReceivedEvent()
        {
            ComPort.DataReceived -= AutoRun_DataReceived;
        }

#if timerEvent
        public void StopSendDataTimerTick()
        {
            SendDataTimer.Enabled = false;
            SendDataTimer.Tick -= SendDataTimerTick;
            Thread.Sleep(500);
            SendDataTimer.Dispose();
            Thread.Sleep(500);
            SendDataTimer.Stop();
        }

        private void SendDataTimerTick(object sender, EventArgs e)
        {
             ComPort.AutonACSwitch(isACON);       
            long msTimes = sw.ElapsedMilliseconds;  //取得執行時間
            string AC_Status = (isACON == true) ? "AC ON " : "AC OFF";
            listBox_Info.Invoke(new Action(() => { WriteMsgToListBox(SendDatatCounter + "   " + AC_Status + "    " + "waitTime: " + Math.Abs(msTimes) + "  rep" + repeatTime); }));
            CheckCounter(SendDatatCounter);
            isACON = (isACON == true) ? false : true;
            StopWatchControl();
}
#else
        private void SendDataTimerTick()
        {
            if (isTimerInvalid == false)
            { 
                ComPort.AutonACSwitch(isACON);
                long msTimes = sw.ElapsedMilliseconds;  //取得執行時間
                string AC_Status = (isACON == true) ? "ON " : "OFF";
                TBOX_Info.Invoke(new Action(() => {
                    WriteMsgToTextBox(SendDatatCounter + "   " + AC_Status + "    " + "waitTime: " + Math.Abs(msTimes) + " [ms]" + "  Dec = " + decDelayTime + "  rep" + repeatTime);
                    WriteMsgToText(  SendDatatCounter + "   " + AC_Status + "    " + "waitTime: " + Math.Abs(msTimes) + " [ms]" + "  Dec = " + decDelayTime + "  rep" + repeatTime);
                }));
               
                CheckCounter(SendDatatCounter);
                isACON = (isACON == true) ? false : true;
                StartWatchControl();
            }
        }
#endif
        private void AutoRun_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string RCommand;
            RCommand = ComPort.AutoReceived();

            if (TBOX_Info.InvokeRequired)
            {
                    TimeSpan mntOnTime = DateTime.Now - sendOnTime;
                    TBOX_Info.Invoke(new Action(() => {
                        WriteMsgToTextBox("MNT ON Time: " + mntOnTime.Seconds + mntOnTime.Milliseconds);
                        File.AppendAllText(@"D:\log.txt", "MNT ON Time: " + mntOnTime.Seconds + mntOnTime.Milliseconds + "\r\n");                    
                    }));
            }
        }

        private void StartWatchControl()
        {
            sw.Stop();
            sw.Start();
            sw.Reset();
            sw.Restart();
            long frequency = Stopwatch.Frequency;
        }

        private void MsTimeCorrection()  //減少timer誤差
        {
            timeBeginPeriod(1);
            uint start = timeGetTime();
            while (isPressStartButton == true)
            {
                uint now = timeGetTime();
                if ((now - start) >= CheckTimerInterval(isACON, decDelayTime))
                {
                    //執行function
                    SendDataTimerTick();
                    start = now;
                }
            }
            timeEndPeriod(1);
        }

        private void Btn_SaveTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|all files|*.*";
            sfd.FileName = "Log";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;          
            if (sfd.ShowDialog() == DialogResult.OK
                     && sfd.FileName.Length > 0)
            {
                MessageBox.Show("Save Path: " + sfd.FileName.ToString());  //印出儲存路徑
                File.Copy(@"D:\log.txt", @sfd.FileName.ToString());    
            }
            TBOX_Info.Clear();
            File.Delete(@"D:\log.txt");
            Application.Exit();
        }

        private void Btn_ACON_Click(object sender, EventArgs e)
        {
            try
            {
                ComPort.Wcmd_ACON();
            }
            catch (InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }

        private void Btn_ACOFF_Click(object sender, EventArgs e)
        {
            try
            {
                ComPort.Wcmd_ACOFF();
            }
            catch (InvalidOperationException ex)
            {
                CheckPortErrorMsg(ex);
            }
        }
    }
}
