using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcmunasada
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, c, d;
            c=double.Parse(textBox1.Text);
            d=double.Parse(textBox2.Text);
            a= c + d;
            label3.Text = a.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, c, d;
            c = double.Parse(textBox1.Text);
            d = double.Parse(textBox2.Text);
            a = c - d;
            label3.Text = a.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, c, d;
            c = double.Parse(textBox1.Text);
            d = double.Parse(textBox2.Text);
            a = c * d;
            label3.Text = a.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, c, d;
            c = double.Parse(textBox1.Text);
            d = double.Parse(textBox2.Text);
            a = c / d;
            label3.Text = a.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
