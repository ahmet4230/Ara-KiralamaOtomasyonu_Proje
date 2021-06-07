using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyonu
{
    public partial class AracForm : Form
    {
        public AracForm()
        {
            InitializeComponent();
        }

        private void AracForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracEkleLbl_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (baglanti.State == ConnectionState.Closed)
            //        baglanti.Open();

            //    string kayit = "insert into Kullanıcı (Kullanıcı_Ad,Kullanıcı_Sifre)values(@Kullanıcıİsim,@KullanıcıSifre)";
            //    SqlCommand komut = new SqlCommand(kayit, baglanti);

            //    komut.Parameters.AddWithValue("@Kullanıcıİsim", KullanıcıİsimTxt1.Text);
            //    komut.Parameters.AddWithValue("@KullanıcıSifre", KullanıcıSifreTxt.Text);

            //    komut.ExecuteNonQuery();

            //    baglanti.Close();
            //    MessageBox.Show("KAYIT BAŞARILI");
            //}
            //catch (Exception hata)
            //{
            //    MessageBox.Show("KAYIT EKLEME İŞLEMİ SIRASINDA HATA OLUŞTU" + hata.Message);
            }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {

        }

        private void AracBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void PazarlananYerNoLbl_Click(object sender, EventArgs e)
        {

        }
    }

      
    }

