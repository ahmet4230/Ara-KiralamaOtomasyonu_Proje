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
    public partial class MusteriEklemeForm : Form
    {
        
        public MusteriEklemeForm()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);


        private void EkleBtn_MouseHover(object sender, EventArgs e)
        {
            this.EkleBtn.BackColor = System.Drawing.Color.Green;
        }

        private void EkleBtn_MouseLeave(object sender, EventArgs e)
        {
            this.EkleBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void İptalBtn_MouseHover(object sender, EventArgs e)
        {
            this.İptalBtn.BackColor = System.Drawing.Color.Red;
        }

        private void İptalBtn_MouseLeave(object sender, EventArgs e)
        {
            this.İptalBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void İptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
               
                string kayit = "insert into Musteriler (Musteri_Ad,Musteri_Soyad,Musteri_Dogum_Tarihi,Telefon,Ehliyet_Cinsi,Tc)values(@Ad,@Soyad,@dOG_tAR,@Telefon,@Ehliyet,@Tc)";             
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Ad", MusteriAdTxt.Text);
                komut.Parameters.AddWithValue("@Soyad", MusteriSoyadTxt.Text);
                komut.Parameters.AddWithValue("@dOG_tAR", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@Telefon", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@Ehliyet", EhliyetTxt.Text);
                komut.Parameters.AddWithValue("@Tc", MusteriTcTxt.Text);               
                komut.ExecuteNonQuery();
             
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";

        }

        private void EhliyetTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MusteriDogTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MusteriDogLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriTelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriTcTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriSoyadTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriAdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriSoyadLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriTclLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriTelefonNoLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriEhliyetLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriAdLbl_Click(object sender, EventArgs e)
        {

        }

        private void MusteriEklemeForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
