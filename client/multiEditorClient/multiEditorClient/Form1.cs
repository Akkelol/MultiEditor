using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            textBox1.Hide();
            textBox2.Hide();
            label1.Hide();
            label2.Hide();
            label3.Show();
            button1.Hide();
            button2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            label1.Show();
            label2.Show();
            label3.Hide();
            button1.Show();
            button2.Hide();
        }
    }
}
