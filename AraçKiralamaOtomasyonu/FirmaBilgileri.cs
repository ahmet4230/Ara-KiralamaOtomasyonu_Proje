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
    public partial class FirmaBilgileri : Form
    {
        public FirmaBilgileri()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);

        public void Kayıt_Getir()
        {
            baglanti.Open();
            string data = "select * from Firma_İsim";
            SqlCommand kom = new SqlCommand(data, baglanti);
            SqlDataAdapter ad = new SqlDataAdapter(kom);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void GeriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirmaBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {

            Kayıt_Getir();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
        }

        

        private void EkleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into Firma_İsim (Adres,Telefon,Calisan_Sayisi)values(@Adres,@Telefon,@Calisan_Sayisi)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                
                komut.Parameters.AddWithValue("@Adres", AdresTxt.Text);
                komut.Parameters.AddWithValue("@Telefon", TelefonMskbx.Text);
                komut.Parameters.AddWithValue("@Calisan_Sayisi", CalısanSayısıTxt.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("FİRMA Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Firma_İsim set  Adres=@Adres,Telefon=@Telefon,Calisan_Sayisi=@Calisan_Sayisi where Adres=@Adres  ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adres", AdresTxt.Text);
            komut.Parameters.AddWithValue("@Telefon", TelefonMskbx.Text);
            komut.Parameters.AddWithValue("@Calisan_Sayisi", CalısanSayısıTxt.Text);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Getir();
            MessageBox.Show("Firma bilgisi Başarıyla Güncellenmiştir");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            AdresTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TelefonMskbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CalısanSayısıTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void SilBtbn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("delete from Firma_İsim where Adres='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
            sil.ExecuteNonQuery();
            MessageBox.Show("Firma bilgisi Başarıyla Silinmiştir");
            baglanti.Close();

        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is MaskedTextBox) item.Text = "";
        }
    }
}
