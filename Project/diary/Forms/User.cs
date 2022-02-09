using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary.Forms
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = diary.Properties.Settings.Default.user_name;
            this.textBox2.Text = diary.Properties.Settings.Default.password;


            string file = Application.StartupPath + "\\data\\pics\\user_pic.jpg";

            this.pictureBox1.Load(file);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.openFileDialog1.FileName == "")
            {
                MessageBox.Show("Please Add all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(this.textBox2.Text != this.textBox3.Text)
            {
                MessageBox.Show("Password Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            diary.Properties.Settings.Default.user_name = this.textBox1.Text;
            diary.Properties.Settings.Default.password = this.textBox2.Text;
            diary.Properties.Settings.Default.profile_pic = this.openFileDialog1.FileName;
            diary.Properties.Settings.Default.Save();

             
            if (this.openFileDialog1.FileName != "openFileDialog1")
            {
           
                string des = Application.StartupPath + "//data//pics//user_pic.jpg";
                System.IO.File.Copy(this.openFileDialog1.FileName, des, true);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string f = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(f);

            
        }
    }
}
