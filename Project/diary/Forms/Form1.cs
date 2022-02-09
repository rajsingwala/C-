using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            diary.Forms.Login obj = new diary.Forms.Login();
            obj.ShowDialog();

            this.label7.Text = Application.ProductVersion;

            string file = Application.StartupPath + "//data//pics/deckerstar.jpg";

            this.BackgroundImage = Image.FromFile(file);

            string file2 = Application.StartupPath + "\\data\\pics\\user_pic.jpg";
            this.pictureBox2.Load(file2);

            this.label10.Text = diary.Properties.Settings.Default.user_name;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Ask",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK){
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void get_Month()
        {
            string m = DateTime.Now.Month.ToString();
            switch (m)
            {
                case "1":
                    this.label3.Text = "January";
                    break;
                case "2":
                    this.label3.Text = "February";
                    break;
                case "3":
                    this.label3.Text = "March";
                    break;
                case "4":
                    this.label3.Text = "April";
                    break;
                case "5":
                    this.label3.Text = "May";
                    break;
                case "6":
                    this.label3.Text = "June";
                    break;
                case "7":
                    this.label3.Text = "July";
                    break;
                case "8":
                    this.label3.Text = "August";
                    break;
                case "9":
                    this.label3.Text = "September";
                    break;
                case "10":
                    this.label3.Text = "October";
                    break;
                case "11":
                    this.label3.Text = "November";
                    break;
                case "12":
                    this.label3.Text = "December";
                    break;
            }
        }

        private void get_Day()
        {
            string d = DateTime.Now.DayOfWeek.ToString();
            this.label4.Text = d;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label2.Text = DateTime.Now.Year.ToString();

            get_Month();

            this.label5.Text = DateTime.Now.Day.ToString();
            get_Day();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "//data//pics//" + comboBox1.SelectedItem;
            this.BackgroundImage = Image.FromFile(file);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary.Forms.About_Us obj = new diary.Forms.About_Us();
            obj.MdiParent = this;
            obj.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary.Forms.User obj = new diary.Forms.User();
            obj.MdiParent = this;
            obj.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary.Forms.Login obj = new diary.Forms.Login();
            obj.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            diary.Forms.Memo obj = new diary.Forms.Memo();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
