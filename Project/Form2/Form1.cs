using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = Application.StartupPath + "\\calc.exe";
            this.process1.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.Size.Width == 846 && this.Size.Height == 497) {
                this.Size = new Size(150, 700);
            }
            else
            {
                this.Size = new Size(846, 497);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            long i;
            Int64.TryParse(this.textBox1.Text,out i);
            // this.textBox2.Text = i.ToString("#,#");
            this.textBox2.Text = this.textBox1.Text.Length.ToString();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Want to Quit?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox1.Text, TextDataFormat.UnicodeText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Clipboard.GetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Enabled = false;
            this.panel1.Visible = true;
            this.panel1.Refresh();
            this.label1.Refresh();

            this.richTextBox1.LoadFile(Application.StartupPath + "\\start.rtf");
            this.panel1.Visible = false;
            this.button6.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class1.msg();
        }
    }
}
