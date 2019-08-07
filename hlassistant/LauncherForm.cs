using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hlassistant
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
            if (!Directory.Exists("cstrike"))
            {
                cscbx.Enabled = false;
            }

            if (!Directory.Exists("ag"))
            {
                agcbx.Enabled = false;
            }

            if (!Directory.Exists("bshift"))
            {
                bscbx.Enabled = false;
            }

            if (!Directory.Exists("gearbox"))
            {
                ofcbx.Enabled = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e) => MessageBox.Show(resolution.SelectedIndex.ToString());

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Dccbx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
