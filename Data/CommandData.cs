using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SerialComTESTProgram
{
    [Serializable]
    public class CommandData
    {
        private string m_Name;
        private string m_Command;
        private bool m_STX;
        private bool m_ETX;
        private bool m_CR;
        private bool m_LF;

        [Category("1. NAME")]
        [DisplayName("NAME")]
        [ReadOnly(false)]
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        [Category("2. COMMAND")]
        [DisplayName("COMMAND")]
        [ReadOnly(false)]
        public string Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }
        [Category("3. OTHERS")]
        [DisplayName("STX")]
        [ReadOnly(false)]
        public bool STX
        {
            get { return m_STX; }
            set { m_STX = value; }
        }
        [Category("3. OTHERS")]
        [DisplayName("ETX")]
        [ReadOnly(false)]
        public bool ETX
        {
            get { return m_ETX; }
            set { m_ETX = value; }
        }
        [Category("3. OTHERS")]
        [DisplayName("CR")]
        [ReadOnly(false)]
        public bool CR
        {
            get { return m_CR; }
            set { m_CR = value; }
        }
        [Category("3. OTHERS")]
        [DisplayName("LF")]
        [ReadOnly(false)]
        public bool LF
        {
            get { return m_LF; }
            set { m_LF = value; }
        }
    }
}
