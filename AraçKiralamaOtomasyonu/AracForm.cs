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
    public partial class AracForm : Form
    {
        public AracForm()
        {
            InitializeComponent();
        }
        public void Kayıt_Getir()
        {
            baglanti.Open();
            string data = "select DISTINCT * from Markalar inner join Modeller on Markalar.Marka_ID = Modeller.Marka_ID ";
            SqlCommand komut = new SqlCommand(data, baglanti);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
       
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracEkleLbl_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Modeller (Marka_ID,Model_Adi,Yil,Renk,Arac_Plaka,Kira_Bedeli,Hakkında)values(@Marka_ID,@Model_Adi,@Yil,@Renk,@Arac_Plaka,@Kira_Bedeli,@Hakkında)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Marka_ID", MarkalNotxt.Text);
                komut.Parameters.AddWithValue("@Model_Adi", ModelTxt.Text);
                komut.Parameters.AddWithValue("@Renk", RenkTxt.Text);
                komut.Parameters.AddWithValue("@Arac_Plaka",PlakaTxt.Text);
                komut.Parameters.AddWithValue("@Kira_Bedeli", GunlukFiyatTxt.Text);
                komut.Parameters.AddWithValue("@Yil", ModelYılıTxt.Text);
               
                komut.Parameters.AddWithValue("@Hakkında", HakkındaTxt.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("'MODEL'Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Markalar set Marka_Ad= @Marka_Ad,Pazarlanan_Satış_Yer_Id=@Pazarlanan_Satış_Yer_Id,Model_Sayisi=@Model_Sayisi where Marka_Ad=@Marka_Ad  ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Marka_Ad", MarkaİsimTxt.Text);
            komut.Parameters.AddWithValue("@Pazarlanan_Satış_Yer_Id", comboBox1.Text);
            komut.Parameters.AddWithValue("@Model_Sayisi", ModelSayıTxt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Getir();
            MessageBox.Show("Marka bilgisi Başarıyla Güncellenmiştir");
         
        }


        private void MarkaEkleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Markalar (Marka_Ad,Pazarlanan_Satış_Yer_Id,Model_Sayisi)values(@Marka_Ad,@satış_yeri,@model_sayısı)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Marka_Ad", MarkaİsimTxt.Text);
                komut.Parameters.AddWithValue("@satış_yeri", comboBox1.Text);
                komut.Parameters.AddWithValue("@model_sayısı", ModelSayıTxt.Text);
              
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("'MARKA'Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                

            }
          

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MarkaİsimTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ModelSayıTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            ModelTxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            ModelYılıTxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            RenkTxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            PlakaTxt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            GunlukFiyatTxt.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            HakkındaTxt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıt_Getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Modeller set Model_Adi=@Model_Adi, Renk=@Renk,Arac_Plaka=@Arac_Plaka,Kira_Bedeli=@Kira_Bedeli,Yil=@Yil,Hakkında=@Hakkında where Arac_Plaka=@Arac_Plaka  ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            
            komut.Parameters.AddWithValue("@Model_Adi", ModelTxt.Text);
            komut.Parameters.AddWithValue("@Renk", RenkTxt.Text);
            komut.Parameters.AddWithValue("@Arac_Plaka", PlakaTxt.Text);
            komut.Parameters.AddWithValue("@Kira_Bedeli", GunlukFiyatTxt.Text);
            komut.Parameters.AddWithValue("@Yil", ModelYılıTxt.Text);
          
            komut.Parameters.AddWithValue("@Hakkında", HakkındaTxt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Getir();
            MessageBox.Show("Model bilgisi Başarıyla Güncellenmiştir");
            
        }
        private void button4_Click(object sender, EventArgs e)
        {

            
            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from Modeller where Arac_Plaka='" + dataGridView1.CurrentRow.Cells[9].Value.ToString() + "'", baglanti);
            sil.ExecuteNonQuery();
            MessageBox.Show("ARAÇ Bilgisi Başarıyla Silinmiştir");

            baglanti.Close();
        }

        private void MarkaListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string data = "select * from markalar ";
            SqlCommand komut = new SqlCommand(data, baglanti);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;

            baglanti.Close();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MarkaİsimTxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            ModelSayıTxt.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void tmzleBtn_Click(object sender, EventArgs e)
        {
            MarkaİsimTxt.Clear();
            comboBox1.ResetText();           
            ModelTxt.Clear();
            MarkalNotxt.Clear();
            PlakaTxt.Clear();
            RenkTxt.Clear();
            GunlukFiyatTxt.Clear();
            HakkındaTxt.Clear();
            ModelYılıTxt.Clear();
            ModelSayıTxt.Clear();

        }
    }

      
    }

