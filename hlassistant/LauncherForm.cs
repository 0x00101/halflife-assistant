﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Dccbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("debugmode.hla");
            int debug = Int32.Parse(sr.ReadToEnd());
            sr.Close();

            if (debug == 1)
            {
                MessageBox.Show("Индекс компонента resolution: " + resolution.SelectedIndex.ToString());
            }

            string freq = " -freq 60";
            string nofbo = " -nofbo";
            string reso640 = " -w 640 -h 480";
            string reso800 = " -w 800 -h 600";
            string reso1024 = " -w 1024 -h 768";
            string opengl = " -gl";
            string main = "hl.exe";

            string parlist = main;
            
            switch (resolution.SelectedIndex.ToString())
            {
                case "0":
                    parlist = parlist + reso640;
                    break;

                case "1":
                    parlist = parlist + reso800;
                    break;

                default:
                    parlist = parlist + reso1024;
                    break;

            }

            if (c_nofbo.Checked == true)
            {
                parlist = parlist + nofbo;
            }

            if (debug == 1)
            {
                MessageBox.Show("Полная строка parlist: " + parlist);
            }

            //Process.Start(parlist);
        }
    }
}
