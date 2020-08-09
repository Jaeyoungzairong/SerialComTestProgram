using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
//using System.Threading;

namespace SerialComTESTProgram
{
    public partial class MainForm : Form
    {
        private SettingForm m_SettingForm;
        private ComPortManager m_ComPortManager;
        private SocketManager m_SocketManager;

        private string m_ComPortName = "COM1";
        private int m_BuadRate = 9600;
        private int m_DataBits = 8;
        private StopBits m_StopBits = StopBits.One;
        private Parity m_ParityBits = Parity.None;

        private string m_Address = "192.168.0.1";
        private int m_PortNum = 7000;

        private List<CommandData> m_Command;

        private Timer m_Timer = new Timer();
        private bool m_RepeatSendStart = true;

        private readonly byte STX = 0x02;
        private readonly byte ETX = 0x03;
        private readonly byte ACK = 0x05;
        private readonly byte CR = 0x0D;
        private readonly byte LF = 0x0A;
        private readonly byte ESC = 0x1B;

        public MainForm()
        {
            InitializeComponent();
            m_SettingForm = new SettingForm(this);
            m_ComPortManager = new ComPortManager(this);
            m_SocketManager = new SocketManager(this);

            m_Command = new List<CommandData>();
            
            m_Timer.Tick += new EventHandler(Timer_Tick);

            UpdateState();
            rbSerial.Checked = true;
        }

        public void UpdateState()
        {
            m_ComPortName = SettingData.Instance.PortName.ToString();
            m_BuadRate = SettingData.Instance.BaudRate.GetHashCode();
            m_DataBits = SettingData.Instance.DataBit.GetHashCode();
            m_ParityBits = (Parity)SettingData.Instance.Paritys;
            m_StopBits = (StopBits) SettingData.Instance.StopBit;

            m_Address = SettingData.Instance.Address;
            m_PortNum = SettingData.Instance.PortNum;

            m_Command = SettingData.Instance.CommandDataList;

            m_Timer.Interval = SettingData.Instance.Interval;

            lbPortName.Text = m_ComPortName;
            lbBaudRate.Text = m_BuadRate.ToString();
            lbDataBit.Text = m_DataBits.ToString();
            lbParityBit.Text = m_ParityBits.ToString();
            lbStopBit.Text = m_StopBits.ToString();

            lbAddress.Text = m_Address;
            lbPortNum.Text = m_PortNum.ToString();

            cbCommand.Items.Clear();
            foreach (CommandData item in m_Command)
            {
                cbCommand.Items.Add(item.Name);
            }
        }

        private byte[] SetCommand(string Command)
        {
            int len = Command.Length;
            if (cbSTX.Checked) len++;
            if (cbETX.Checked) len++;
            if (cbCR.Checked) len++;
            if (cbLF.Checked) len++;
            byte[] msg = new byte[len];

            int index = 0;
            if (cbSTX.Checked) msg[index++] = STX;
            for (int i = 0; i < Command.Length; i++)
            {
                msg[index++] = (byte)Command[i];
            }
            if (cbETX.Checked) msg[index++] = ETX;
            if (cbCR.Checked) msg[index++] = CR;
            if (cbLF.Checked) msg[index++] = LF;

            return msg;
        }

        public void WriteText(string text)
        {
            string time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2") + " ";
            tbSendMessage.AppendText(time + text + Environment.NewLine);
            tbSendMessage.ScrollToCaret();
        }

        public void WriteReceiveText(string text)
        {
            if (this.InvokeRequired)
            {
                DelVoid_String del = new DelVoid_String(WriteReceiveText);
                this.Invoke(del, text);
            }
            else
            {
                string time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2") + " ";
                tbReceiveMessage.AppendText(time + text + Environment.NewLine);
                tbReceiveMessage.ScrollToCaret();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_ComPortManager.Disconnect();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string Msg = tbCommand.Text;
            if (Msg == null || Msg == string.Empty)
            {
                WriteText("No Command Error");
            }
            else
            {
                byte[] msg = SetCommand(Msg);
                if (rbSerial.Checked)
                {
                    if (m_ComPortManager.WriteCommand(msg)) WriteText(Msg);
                    else WriteText("Command Write Error");
                }
                else if (rbTCP.Checked)
                {
                    if (m_SocketManager.SendCommand(Msg)) WriteText(Msg);
                    else WriteText("Command Write Error");
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            m_SettingForm.Show();
        }

        private void btnComPortOpen_Click(object sender, EventArgs e)
        {
            if (m_ComPortManager.SetPortInfo(m_ComPortName, m_BuadRate, m_DataBits, m_StopBits, m_ParityBits))
            {
                if (m_ComPortManager.Connect()) WriteText("ComPort Connect Success");
                else WriteText("ComPort Connect Error");
            }
            else
            {
                WriteText("SerialPort Information Error");
            }
        }

        private void btnComPortClose_Click(object sender, EventArgs e)
        {
            if (m_ComPortManager.Disconnect())
            {
                WriteText("ComPort Disconnect Success");
            }
            else
            {
                WriteText("ComPort Disconnect Error");
            }
        }

        private void btnTCPConnect_Click(object sender, EventArgs e)
        {
            if (m_SocketManager.Connenct(m_Address, m_PortNum))
            {
                WriteText("TCP Connect Success");
            }
            else
            {
                WriteText("TCP Connect Error");
            }
        }

        private void btnTCPDisconnect_Click(object sender, EventArgs e)
        {
            m_SocketManager.Disconnenct(m_Address, m_PortNum);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string Msg = tbCommand.Text;
            if (Msg == null || Msg == string.Empty)
            {
                WriteText("No Command Error");
            }
            else
            {
                byte[] msg = SetCommand(Msg);
                if (rbSerial.Checked)
                {
                    if (m_ComPortManager.WriteCommand(msg)) WriteText(Msg);
                    else WriteText("Command Write Error");
                }
                else if (rbTCP.Checked)
                {
                    if (m_SocketManager.SendCommand(Msg)) WriteText(Msg);
                    else WriteText("Command Write Error");
                }
            }
        }

        private void btnContinueSend_Click(object sender, EventArgs e)
        {
            if (m_RepeatSendStart)
            {
                m_RepeatSendStart = false;

                tableLayoutMode.Enabled = false;
                tableLayoutSerial.Enabled = false;
                tableLayoutTCP.Enabled = false;
                tableLayoutCommand.Enabled = false;

                btnSend.Enabled = false;
                btnSetting.Enabled = false;
                btnCheckSum.Enabled = false;

                m_Timer.Start();
            }
            else if (!m_RepeatSendStart)
            {
                m_RepeatSendStart = true;

                tableLayoutMode.Enabled = true;
                tableLayoutSerial.Enabled = true;
                tableLayoutTCP.Enabled = true;
                tableLayoutCommand.Enabled = true;

                btnSend.Enabled = true;
                btnSetting.Enabled = true;
                btnCheckSum.Enabled = true;

                m_Timer.Stop();
            }
            m_SettingForm.Hide();
        }

        private void btnTextClear_Click(object sender, EventArgs e)
        {
            tbSendMessage.Text = string.Empty;
            tbReceiveMessage.Text = string.Empty;
        }

        private void btnCheckSum_Click(object sender, EventArgs e)
        {
            int checksum = 0;
            string text = tbCommand.Text;
            if (text == null || text == string.Empty)
            {
                WriteText("No Command Error");
            }
            else
            {
                int count = text.Length;
                char[] dataarray = text.ToCharArray(0, count);
                foreach (char letter in dataarray)
                {
                    int value = Convert.ToInt16(letter);
                    checksum += value;
                    WriteReceiveText(value.ToString());
                }
                text = string.Format("{0:X}", checksum);
                lbCommand.Text = "CheckSum Result : " + text;
            }
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CommandData item in SettingData.Instance.CommandDataList)
            {
                if (cbCommand.SelectedItem.ToString() == item.Name)
                {
                    cbSTX.Checked = item.STX;
                    cbETX.Checked = item.ETX;
                    cbCR.Checked = item.CR;
                    cbLF.Checked = item.LF;
                    tbCommand.Text = item.Command;
                }
            }
        }

        private void rbSerial_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutSerial.Enabled = true;
            tableLayoutTCP.Enabled = false;
        }

        private void rbTCP_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutSerial.Enabled = false;
            tableLayoutTCP.Enabled = true;
        }

        private void TbCommand_TextChanged(object sender, EventArgs e)
        {
            string cmd = tbCommand.Text;
            if (cmd.Length > 0)
            {
                if (cbSTX.Checked) cmd = "STX+" + cmd;
                if (cbETX.Checked) cmd = cmd + "+ETX";
                if (cbCR.Checked) cmd = cmd + "+CR";
                if (cbLF.Checked) cmd = cmd + "+LF";
                lbCommand.Text = cmd;
            }
            else
            {
                lbCommand.Text = "Command";
            }
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            string cmd = tbCommand.Text;
            if (cmd.Length > 0)
            {
                if (cbSTX.Checked) cmd = "STX+" + cmd;
                if (cbETX.Checked) cmd = cmd + "+ETX";
                if (cbCR.Checked) cmd = cmd + "+CR";
                if (cbLF.Checked) cmd = cmd + "+LF";
                lbCommand.Text = cmd;
            }
            else
            {
                lbCommand.Text = "Command";
            }
        }
    }
}
