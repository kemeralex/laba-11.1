using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace laba_11
{
    public partial class Form1 : Form
    {
        private double n;
        private double otvet;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            hScrollBar1.Value = Convert.ToInt32(textBox3.Text);
            n = Convert.ToDouble(textBox3.Text);
            for (int i = 1; i <= n; i++)
            {
                otvet += i * i;
            }
            textBox1.Text = Convert.ToString(otvet);
            otvet = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hScrollBar1.Value = Convert.ToInt32(textBox3.Text);
            n = Convert.ToDouble(textBox3.Text);
            otvet = (n * (n + 1) * (2 * n + 1)) / 6;
            textBox1.Text = Convert.ToString(otvet);
            otvet = 0;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = Convert.ToString(hScrollBar1.Value);
            hScrollBar1.Maximum = 46000;
            n = hScrollBar1.Value;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
