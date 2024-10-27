using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, topla;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            topla = sayi1 + sayi2;
            textBox3.Text = topla.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carp;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            carp = sayi1 * sayi2;
            textBox3.Text = carp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikart;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            cikart = sayi1 - sayi2;
            textBox3.Text = cikart.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, bol;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            bol = sayi1 / sayi2;
            textBox3.Text = bol.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, mod;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            mod = sayi1 % sayi2;
            textBox3.Text = mod.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sayi1, kare;
            sayi1 = Convert.ToDouble(textBox1.Text);
            kare = sayi1 * sayi1;
            textBox3.Text = kare.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sayi1, küp;
            sayi1 = Convert.ToDouble(textBox1.Text);
            küp = sayi1 * sayi1 * sayi1;
            textBox3.Text = küp.ToString();

        }
    }
}
