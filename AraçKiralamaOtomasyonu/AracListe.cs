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
    public partial class AracListe : Form
    {
        public AracListe()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-7QT69QN;Initial Catalog = Arac_Kiralama_Final1; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(conString);


        private void AracListe_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

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
    }
}
