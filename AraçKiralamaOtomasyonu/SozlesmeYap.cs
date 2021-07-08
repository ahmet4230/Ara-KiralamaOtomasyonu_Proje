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
    public partial class Sözleşme_Yap : Form
    {
        public Sözleşme_Yap()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection con = new SqlConnection(conString);

        public void Musteri_Ara(TextBox Musteri_ID, TextBox MusteriAd, TextBox MusteriSoyad, TextBox Tc , MaskedTextBox Telefon, ComboBox Ehliyet, string sorgu )
        {

            con.Open();
            SqlCommand komn = new SqlCommand(sorgu,con);
            SqlDataReader read = komn.ExecuteReader();
            while (read.Read())
            {
                MusteriAdTxt.Text = read["Musteri_Ad"].ToString();
                MusteriSoyadTxt.Text = read["Musteri_Soyad"].ToString();
                maskedTextBox2.Text = read["Telefon"].ToString();
                MusteriTcTxt.Text = read["Tc"].ToString();
                EhliyetTxt1.Text = read["Ehliyet_Cinsi"].ToString();
                Musteri_NoTxt.Text = read["Musteri_ID"].ToString();
            }
            con.Close();

        }
        public void Kayıt_Getir()
        {
            con.Open();
            string data = "select * from Yapılan_Kiralamalar";
            SqlCommand komut = new SqlCommand(data, con);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        public void ComboGetir(ComboBox cmb, TextBox Arac, TextBox renk, TextBox fiyat, TextBox modelYili, TextBox Model_Id, string sorgu )
        {
            con.Open();
            SqlCommand komn = new SqlCommand(sorgu, con);
            SqlDataReader read = komn.ExecuteReader();
            while (read.Read())
            {
                ModelTxt.Text = read["Model_Adi"].ToString();
                RenkTxt.Text = read["Renk"].ToString();
                GunlukFiyatTxt.Text = read["Kira_Bedeli"].ToString();
                ModelYılıTxt.Text = read["Yil"].ToString();
                ModelNotxt.Text = read["Model_ID"].ToString();


            }
            con.Close();
        }
      
        

        

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string kayit = "insert into Yapılan_Kiralamalar (Musteri_ID,Musteri_Ad,Musteri_Soyad,Musteri_Tc,Musteri_Telefon,Ehliyet_Cinsi,Arac_No,Arac_Plaka,Alım_Tarihi,Teslim_Tarihi,Arac,Renk,Kiralama_Fiyatı)values(@Musteri_ID,@Ad,@Soyad,@tc,@Telefon,@Ehliyet,@AracNo,@Plaka,@AlımT,@TeslimT,@Arac,@Renk,@Fiyat)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Musteri_ID", Musteri_NoTxt.Text);
                komut.Parameters.AddWithValue("@Ad", MusteriAdTxt.Text);
                komut.Parameters.AddWithValue("@Soyad", MusteriSoyadTxt.Text);
                komut.Parameters.AddWithValue("@tc", MusteriTcTxt.Text);
                komut.Parameters.AddWithValue("@Telefon", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@Ehliyet", EhliyetTxt1.Text);
                komut.Parameters.AddWithValue("@AracNo", ModelNotxt.Text);
                komut.Parameters.AddWithValue("@Plaka", PlakaCombx.Text);
                komut.Parameters.AddWithValue("@AlımT", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@TeslimT", dateTimePicker2.Text);
                komut.Parameters.AddWithValue("@Arac", ModelTxt.Text);
                komut.Parameters.AddWithValue("@Renk", RenkTxt.Text);
                komut.Parameters.AddWithValue("@Fiyat", GunlukFiyatTxt.Text);




                komut.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("SÖZLEŞME İşlemi Gerçekleşti." + MusteriAdTxt.Text + " " + MusteriSoyadTxt.Text +  " " + "\nALIM TARİHİ: " +   dateTimePicker1.Text + "\nTESLİM TARİHİ " + dateTimePicker2.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PlakaCombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sorgu2 = "Select * from Modeller where Arac_Plaka like'" + PlakaCombx.SelectedItem + "'";
            ComboGetir(PlakaCombx, ModelTxt, RenkTxt, GunlukFiyatTxt, ModelYılıTxt, ModelNotxt, sorgu2);
        }

        private void Sözleşme_Yap_Load(object sender, EventArgs e)
        {
          con.Open();
            SqlCommand komn = new SqlCommand("select Arac_Plaka from Modeller",con);
            SqlDataReader read = komn.ExecuteReader();
            while (read.Read())
            {
                PlakaCombx.Items.Add(read["Arac_Plaka"]);
     
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıt_Getir();
        }

        private void MusteriTcTxt_TextChanged(object sender, EventArgs e)
        {
            if (MusteriTcTxt.Text == "")
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = ""; ;
            string sorgu1 = "Select * from Musteriler where Tc like'" + MusteriTcTxt.Text + "'";
            Musteri_Ara(MusteriTcTxt, Musteri_NoTxt,  MusteriAdTxt, MusteriSoyadTxt, maskedTextBox2, EhliyetTxt1, sorgu1);
        }
    }
}
