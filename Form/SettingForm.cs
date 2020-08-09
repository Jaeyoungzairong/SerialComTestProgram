using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SerialComTESTProgram
{
    public partial class SettingForm : Form
    {
        private MainForm m_MainForm;
        public SettingForm(MainForm Form)
        {
            InitializeComponent();
            this.m_MainForm = Form;

            SettingData.Instance.ReadXml();
            pgSettingValue.SelectedObject = SettingData.Instance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingData.Instance.WriteXml();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SettingForm_VisibleChanged(object sender, EventArgs e)
        {
            SettingData.Instance.ReadXml();
            pgSettingValue.SelectedObject = SettingData.Instance;
            m_MainForm.UpdateState();
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
}
