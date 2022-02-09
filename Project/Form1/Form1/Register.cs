using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Data_Click(object sender, EventArgs e)
        {
            this.Save_But.Enabled = true;
            this.New_Data.Enabled = false;
            this.groupBox1.Enabled = true;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
        }

        private void Save_But_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == ""
                || this.textBox5.Text == "" || this.textBox6.Text == "" || this.textBox7.Text == "" || this.textBox8.Text == "")
            {
                MessageBox.Show("Please Add All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Save_But.Enabled = false;
            this.New_Data.Enabled = true;
            this.groupBox1.Enabled = false;

            
        }
    }
}
