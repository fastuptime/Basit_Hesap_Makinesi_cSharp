namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if(deger_1.Text == "" || deger_2.Text == "")
            {
                MessageBox.Show("Lütfen bir sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sayi1 = Convert.ToInt32(deger_1.Text);
                int sayi2 = Convert.ToInt32(deger_2.Text);
                int sonuc_ne = 0;
                if (islem.Text == "Toplama") {
                    sonuc_ne = sayi1 + sayi2;
                }
                else if (islem.Text == "Çıkarma") {
                    sonuc_ne = sayi1 - sayi2;
                }
                else if (islem.Text == "Bölme") {
                    sonuc_ne = sayi1 / sayi2;
                }
                else if (islem.Text == "Çarpma") {
                    sonuc_ne = sayi1 * sayi2;
                }
                else {
                    MessageBox.Show("Lütfen bir işlem seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sonuc.Text = "Sonuç: " + sonuc_ne.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Basit Hesap Makinesi v1.0 GitHub'da Paylaşılmıştır.", "Hesap Makinesi - FastUptime", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //https://github.com/fastuptime/Basit_Hesap_Makinesi_cSharp
        //https://github.com/fastuptime
        //https://fastuptime.com
        //FastUptime
        //Author: ByCan
    }
}