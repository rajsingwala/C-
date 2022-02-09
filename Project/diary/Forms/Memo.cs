using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary.Forms
{
    public partial class Memo : Form
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.groupBox1.Enabled = false;

            int id = diary.Properties.Settings.Default.last_id;
            id = id + 1;

            this.richTextBox1.SaveFile(Application.StartupPath + "\\data\\docs\\" + id.ToString() + ".rtf");

        }

        private void Memo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                button1_Click(sender, e);
            }
            if(e.KeyCode == Keys.F5)
            {
                button2_Click(sender, e);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memo_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 5; ++i)
            {
                this.listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int i = this.listBox1.FindStringExact(this.textBox3.Text);
           this.listBox1.SelectedIndex = i;
        }
    }
}
