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
    public partial class MusterileBilgileri : Form
    {
        public MusterileBilgileri()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection con = new SqlConnection(conString);
        public void Kayıt_Getir()
        {
            con.Open();
            string data = "select * from Musteriler";
            SqlCommand komut = new SqlCommand(data,con);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusterileBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            Kayıt_Getir();
        }

        private void ListeleBtn_MouseHover(object sender, EventArgs e)
        {
            this.ListeleBtn.BackColor = System.Drawing.Color.Green;
        }

        private void ListeleBtn_MouseLeave(object sender, EventArgs e)
        {
            this.ListeleBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void GuncelleBtn_MouseHover(object sender, EventArgs e)
        {
            this.GuncelleBtn.BackColor = System.Drawing.Color.Green;
        }

        private void GuncelleBtn_MouseLeave(object sender, EventArgs e)
        {
            this.GuncelleBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void SilBtn_MouseHover(object sender, EventArgs e)
        {
            this.SilBtn.BackColor = System.Drawing.Color.Red;
        }

        private void SilBtn_MouseLeave(object sender, EventArgs e)
        {
            this.SilBtn.BackColor = System.Drawing.Color.Transparent;
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MusteriAdTxt1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MusteriSoyadTxt1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MusteriTcTxt1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EhliyetTxt1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void SilBtn_Click_1(object sender, EventArgs e)
        {
           
                string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                SqlCommand sil = new SqlCommand("delete from Musteriler where Musteri_ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                sil.ExecuteNonQuery();
                MessageBox.Show("Müşteri Başarıyla Silinmiştir");

            
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Musteriler set Musteri_Ad= @Ad,Musteri_Soyad=@Soyad,Musteri_Dogum_Tarihi=@dOG_tAR,Telefon=@Telefon,Ehliyet_Cinsi=@Ehliyet,Tc=@Tc where Tc=@Tc  ";
            SqlCommand komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("@Ad", MusteriAdTxt1.Text);
            komut.Parameters.AddWithValue("@Soyad", MusteriSoyadTxt1.Text);
            komut.Parameters.AddWithValue("@dOG_tAR", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("@Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@Ehliyet", EhliyetTxt1.Text);
            komut.Parameters.AddWithValue("@Tc", MusteriTcTxt1.Text);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            Kayıt_Getir();
            MessageBox.Show("Müşteri Başarıyla Güncellenmiştir");

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void EhliyetTxt1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MusteriTcTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriSoyadTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriAdTxt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
