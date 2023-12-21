using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje1
{
    public partial class Form2 : Form
    {
        double sayi1;
        double sayi2;
        double sonuc;
        string islem;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            sncekrn.Text = sncekrn.Text + "0";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sncekrn.Clear();
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(sncekrn.Text);
            sncekrn.Clear();
            islem = "+";
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(sncekrn.Text);
            sncekrn.Clear();
            islem = "-";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(sncekrn.Text);
            sncekrn.Clear();
            islem = "*";
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(sncekrn.Text);
            sncekrn.Clear();
            islem = "/";
        }

        private void btnsnc_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(sncekrn.Text);
            if (islem == "+")
            {
                sonuc = (sayi1 + sayi2);
                sncekrn.Text = Convert.ToString(sonuc);
             
            }
            if (islem == "-")
            {
                sonuc = (sayi1 - sayi2);
                sncekrn.Text = Convert.ToString(sonuc);
         
            }
            if (islem == "*")
            {
                sonuc = (sayi1 * sayi2);
                sncekrn.Text = Convert.ToString(sonuc);
            }
            if (islem == "/")
            {
                sonuc = (sayi1 / sayi2);
                sncekrn.Text = Convert.ToString(sonuc);
            }
        }
    }
}