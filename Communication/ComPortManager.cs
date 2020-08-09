using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace SerialComTESTProgram
{
    public class ComPortManager
    {
        private SerialPort m_SerialPort;
        private MainForm m_MainForm;
        public ComPortManager(MainForm Form)
        {
            m_SerialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            m_SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

            this.m_MainForm = Form;
        }

        public bool SetPortInfo(string ComPortNum, int BuadRate, int DataBit, StopBits StopBit, Parity ParityBit)
        {
            try
            {
                m_SerialPort.PortName = ComPortNum;
                m_SerialPort.BaudRate = BuadRate;
                m_SerialPort.DataBits = DataBit;
                m_SerialPort.StopBits = StopBit;
                m_SerialPort.Parity = ParityBit;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Connect()
        {
            try
            {
                if (m_SerialPort.IsOpen)
                {
                    m_SerialPort.Close();
                    Thread.Sleep(1000);
                }                
                m_SerialPort.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public bool Disconnect()
        {
            try
            {
                m_SerialPort.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool WriteCommand(byte[] msg)
        {
            try
            {
                m_SerialPort.Write(msg, 0, msg.Length);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strReceive = m_SerialPort.ReadExisting();
            m_MainForm.WriteReceiveText(strReceive);
        }

        public string[] FindComPort()
        {
            return SerialPort.GetPortNames();
        }
    }
}
