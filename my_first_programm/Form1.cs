using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first_programm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}