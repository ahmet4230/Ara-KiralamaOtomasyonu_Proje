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
    public partial class KullanıcılarForm : Form
    {
        public KullanıcılarForm()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void KullanıcılarForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KullanıcıEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Personel (KullanıcıTc,Yetkili_Ad,Yetkili_Soyad,Yetkili_Sifre,Dog_Tarihi,Telefon,Mail,Hakkında)values(@KullanıcıTc,@Yetkili_Ad,@Yetkili_Soyad,@Yetkili_Sifre,@Dog_Tarihi,@Telefon,@Mail,@Hakkında)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@KullanıcıTc", TcTxt1.Text);
                komut.Parameters.AddWithValue("@Yetkili_Ad", KullanıcıİsimTxt.Text);
                komut.Parameters.AddWithValue("@Yetkili_Soyad", KullanıcıSoyisimTxt.Text);
                komut.Parameters.AddWithValue("@Yetkili_Sifre", KullanıcıSifreTxt.Text);
                komut.Parameters.AddWithValue("@Dog_Tarihi", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@Mail", KMail.Text);
                komut.Parameters.AddWithValue("@Hakkında", HakkındaTxt.Text);
               

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("PERSONEL Kayıt İşlemi Gerçekleşti." + " " + KullanıcıİsimTxt.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string data = "select * from Personel";
            SqlCommand komut = new SqlCommand(data, baglanti);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TcTxt1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KullanıcıİsimTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KullanıcıSoyisimTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KullanıcıSifreTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            KMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            HakkındaTxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KullanıcıSilBtn_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from Personel where Id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            sil.ExecuteNonQuery();
            MessageBox.Show("Personel Başarıyla Silinmiştir" + " " + KullanıcıİsimTxt.Text);
            baglanti.Close();
        }
    }
}
