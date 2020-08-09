using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SerialComTESTProgram
{
    public class INIManager
    {
        private string m_Path;
        public Array m_SectionList = Enum.GetValues(typeof(SectionList));
        public Array m_ComPortList = Enum.GetValues(typeof(ComPortList));
        public Array m_TCPPortList = Enum.GetValues(typeof(TCPPortList));
        public Array m_CommandList = Enum.GetValues(typeof(CommandList));
        public Array m_TimerList = Enum.GetValues(typeof(TimerList));

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val,string filePath);
  
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size,string filePath);

        public INIManager(string INIPath)
        {
            m_Path = INIPath;
        }

        public void WriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.m_Path);
        }
        
        public string ReadValue(string Section, string Key, string Default = "")
        {
            StringBuilder buffer = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, Default, buffer, 255, this.m_Path);

            return buffer.ToString();
        }

        public void WriteValue(string Section, string Key, int Value)
        {
            WritePrivateProfileString(Section, Key, Value.ToString(), this.m_Path);
        }

        public int ReadValue(string Section, string Key, int Default)
        {
            StringBuilder buffer = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, Default.ToString(), buffer, 255, this.m_Path);

            return int.Parse(buffer.ToString());
        }
    }
}
