using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyonu
{
    public partial class KullanıcıKayıt : Form
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
            SqlConnection baglanti = new SqlConnection(conString);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Kullanıcı (Kullanıcı_Ad,Kullanıcı_Sifre)values(@Kullanıcıİsim,@KullanıcıSifre)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Kullanıcıİsim", KullanıcıİsimTxt1.Text);
                komut.Parameters.AddWithValue("@KullanıcıSifre", KullanıcıSifreTxt.Text);
             
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("KAYIT BAŞARILI");
            }
            catch (Exception hata)
            {
                MessageBox.Show("KAYIT EKLEME İŞLEMİ SIRASINDA HATA OLUŞTU" + hata.Message);
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void EkleBtn_MouseHover(object sender, EventArgs e)
        {
            this.EkleBtn.BackColor = System.Drawing.Color.Green;
        }

        private void CıkısBtn_MouseHover(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Red;
        }

        private void EkleBtn_MouseLeave(object sender, EventArgs e)
        {
            this.EkleBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void CıkısBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void CıkısBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
