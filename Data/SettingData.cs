using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.ComponentModel;

namespace SerialComTESTProgram
{
    [Serializable]
    public class SettingData
    {
        public readonly static SettingData Instance = new SettingData(); 

        private string m_FilePath = Application.StartupPath;
        private string m_FileName = "Setting.xml";

        private PortNo m_PortName = PortNo.COM1;
        private BaudRate m_BaudRate = BaudRate._9600;
        private DataBit m_DataBit = DataBit._8;
        private Paritys m_Paritys = Paritys.None;
        private StopBit m_StopBit = StopBit.One;

        private string m_Address = "192.168.0.35";
        private int m_PortNum = 7456;

        private List<CommandData> m_CommandDataList = new List<CommandData>();

        private int m_Interval = 1000;

        [Category("1. SERIAL PORT")]
        [DisplayName("PORT NAME")]
        public PortNo PortName
        {
            get { return m_PortName; }
            set { m_PortName = value; }
        }
        [Category("1. SERIAL PORT")]
        [DisplayName("BUADRATE")]
        public BaudRate BaudRate
        {
            get { return m_BaudRate; }
            set { m_BaudRate = value; }
        }
        [Category("1. SERIAL PORT")]
        [DisplayName("DATA BIT")]
        public DataBit DataBit
        {
            get { return m_DataBit; }
            set { m_DataBit = value; }
        }
        [Category("1. SERIAL PORT")]
        [DisplayName("PARITY BIT")]
        public Paritys Paritys
        {
            get { return m_Paritys; }
            set { m_Paritys = value; }
        }
        [Category("1. SERIAL PORT")]
        [DisplayName("STOP BIT")]
        public StopBit StopBit
        {
            get { return m_StopBit; }
            set { m_StopBit = value; }
        }
        [Category("2. TCP PORT")]
        [DisplayName("ADDRESS")]
        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }
        [Category("2. TCP PORT")]
        [DisplayName("PORT NUMBER")]
        public int PortNum
        {
            get { return m_PortNum; }
            set { m_PortNum = value; }
        }
        [Category("3. DEVICE")]
        [DisplayName("DEVICE LIST")]
        public List<CommandData> CommandDataList
        {
            get { return m_CommandDataList; }
            set { m_CommandDataList = value; }
        }
        [Category("4. TIMER")]
        [DisplayName("INTERVAL TIME")]
        [Description("Reapeat Send Timer Interval")]
        public int Interval
        {
            get { return m_Interval; }
            set { m_Interval = value; }
        }

        public SettingData()
        {

        }

        public bool ReadXml()
        {
            try
            {
                if (CheckPath() == true)
                {
                    string fileName = m_FilePath + "\\" + m_FileName;
                    if (File.Exists(fileName) == true)
                    {
                        XmlManager<SettingData> list = new XmlManager<SettingData>();
                        SettingData data = list.Read(fileName);
                        if (data != null)
                        {
                            this.PortName = data.PortName;
                            this.BaudRate = data.BaudRate;
                            this.DataBit = data.DataBit;
                            this.Paritys = data.Paritys;
                            this.StopBit = data.StopBit;

                            this.Address = data.Address;
                            this.PortName = data.PortName;

                            this.CommandDataList = data.CommandDataList;

                            this.Interval = data.Interval;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + this.ToString());
            }
            return true;
        }

        public void WriteXml()
        {
            try
            {
                if (CheckPath() == true)
                {
                    string fileName = m_FilePath + "\\" + m_FileName;
                    XmlManager<SettingData> list = new XmlManager<SettingData>();
                    list.Save(fileName, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckPath()
        {
            string filePath;
            if (string.IsNullOrEmpty(m_FilePath)) return false;

            if (Directory.Exists(m_FilePath))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Cur Data folder was not found");
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.Description = "Cur Data folder select";
                dlg.SelectedPath = Application.StartupPath;
                dlg.ShowNewFolderButton = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.SelectedPath;
                    m_FilePath = filePath;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
