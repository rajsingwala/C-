using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace diary
{
    public partial class array : Form
    {
        public array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list = new string[4] {"lucifer","chloe","maze","ella"};

            this.listBox1.Items.AddRange(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            string[] list = new string[4] { "lucifer", "chloe", "maze", "ella" };

            Array.Sort(list);
            this.listBox1.Items.AddRange(list);
        }

       
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            string[] list = new string[4] { "lucifer", "chloe", "maze", "ella" };

            Array.Sort(list);
            Array.Reverse(list);
            this.listBox1.Items.AddRange(list);
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            var list = new ArrayList() { 5,this};
            list.Add("hello");
            this.listBox1.Items.AddRange(list.ToArray());
            this.textBox1.Text = list[0].ToString();

            list.RemoveAt(0);
            object o = list[0];
            list.Remove(o);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.listBox1.SelectedItem.ToString();
            
        }

        private void H(object sender, EventArgs e)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "ok");
            h.Add(2, "good");

            foreach (DictionaryEntry item in h)
            {
                MessageBox.Show(item.Value.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SortedList<int,string> s = new SortedList<int,string>();
            s.Add(5, "ok");
            s.Add(1, "good");
            s.Add(8, "Exe");

            foreach(var item in s)
            {
                MessageBox.Show(item.Value.ToString());
            }
        }
    }
}
