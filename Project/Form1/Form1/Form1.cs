using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Search obj = new Search();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.process2.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process2.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton4_Click(sender, e);
            }
        }
    }
}
