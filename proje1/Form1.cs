namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = "hesap";
            string sifre = "123";
            if (txt1.Text == kullanici_adi && txt2.Text == sifre)
            {
                Form2 HesapM = new Form2();
                HesapM.Show();
        }
            
            else 
            {
                MessageBox.Show("yanlýþ kullanýcý adý veya þifre girdiniz tekrar deneyin");      
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullanici_adi = "tahmin";
            string sifre = "123";
            if (txt3.Text == kullanici_adi && txt4.Text == sifre)
            {
                Form3 tahmin = new Form3();
                tahmin.Show();
            }
            else
            {
                MessageBox.Show("yanlýþ kullanýcý adý veya þifre girdiniz tekrar deneyin");
            }
        }

    }
}