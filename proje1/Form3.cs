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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<string> liste_ad = new List<string>();
        List<string> Liste_fiyat = new List<string>();
        List<string> Liste_kazanc = new List<string>();
        List<int> Liste_gunu = new List<int>();
        int sayac = 0;
        double kazanc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string metin = adi.Text;
            int gunsayisi = Convert.ToInt32(guntxt.Text);
            double fiyat = Convert.ToDouble(fiyattxt.Text);
            double adet = Convert.ToDouble(adettxt.Text);
            double ilkgunfiyatı = fiyat;

            for (int i = 1; i <= gunsayisi; i++)
            {
                fiyat = fiyat * 1.10;
                kazanc = fiyat - ilkgunfiyatı;
                kazanc = kazanc * adet;
                liste_ad.Add(adi.Text);
                Liste_gunu.Add(i);
                Liste_fiyat.Add(fiyat.ToString("N1"));
                Liste_kazanc.Add(kazanc.ToString("N1"));
                sayac++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            liste.Items.Clear();
            liste_ad.Clear();
            Liste_gunu.Clear();
            Liste_fiyat.Clear();
            Liste_kazanc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < sayac; j++)
            {
                string deger = liste_ad[j] + "nın" + Liste_gunu[j] + ". gündeki fiyatı:" + Liste_fiyat[j] + "  Sizin kazancınız:" + Liste_kazanc[j];
                liste.Items.Add(deger);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string arananDeger = textara.Text;
            if (!string.IsNullOrEmpty(arananDeger))
            {
                // Aranan değeri içeren son indeksi alın
                int sonIndeks = liste_ad.FindLastIndex(x => x.Contains(arananDeger));

                if (sonIndeks != -1)
                {
                    string sonKazanc = Liste_kazanc[sonIndeks];
                    MessageBox.Show("Aranan ifadeyi içeren son kazanç: " + sonKazanc);
                }
                else
                {
                    MessageBox.Show("Aranan ifadeyi içeren herhangi bir öğe bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen aranacak değeri girin.");
            }
        }
    }
}
