using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Load(Application.StartupPath + "\\data\\pics\\user_pic.jpg");
            this.textBox1.Text = diary.Properties.Settings.Default.user_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text != diary.Properties.Settings.Default.password)
            {
                MessageBox.Show("Password not Matched");
                return;
            }
            else
            {
                this.Close();
            }
        }
    }
}
