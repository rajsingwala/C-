using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary.Forms
{
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void About_Us_Load(object sender, EventArgs e)
        {
            this.label6.Text = Application.ProductName;
            this.label8.Text = Application.ProductVersion;
            this.label7.Text = diary.Properties.Settings.Default.Url;
            this.label9.Text = diary.Properties.Settings.Default.Programmer;
            this.label11.Text = diary.Properties.Settings.Default.Right;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
