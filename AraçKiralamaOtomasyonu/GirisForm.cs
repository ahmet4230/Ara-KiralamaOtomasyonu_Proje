using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AraçKiralamaOtomasyonu
{
    public partial class GirisForm : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        
        public GirisForm()
        {
            InitializeComponent();
        }

       
        


      
        private void GirisForm_Shown(object sender, EventArgs e)
        {
            kullanıcıİsimTxt.Focus();
        }

        

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        

        private void KayıtBtn_Click(object sender, EventArgs e)
        {
            Form KullanıcıKayıt = new KullanıcıKayıt ();
            KullanıcıKayıt.ShowDialog();
            
           
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {
            string user = kullanıcıİsimTxt.Text;
            string psw = kullanıcıŞifreTxt.Text;
            con = new SqlConnection ("Data Source=DESKTOP-7QT69QN;Initial Catalog=Arac_Kiralama_Final1;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Kullanıcı where Kullanıcı_Ad='"+kullanıcıİsimTxt.Text+"' and Kullanıcı_Sifre='"+kullanıcıŞifreTxt.Text + "'" ;
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ İŞLEMİ BAŞARILI HOŞGELDİN" + " " + " ' " + kullanıcıİsimTxt.Text + " ' " );
               
                Form KullanıcıAnaSayfa = new KullanıcıAnsayfa();
                KullanıcıAnaSayfa.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("LÜTFEN GİRİŞ BİLGİLERİNİZİ KONTROL EDİNİZ");
            }
            con.Close();

        }

        private void GirisYap2_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection("Data Source=DESKTOP-7QT69QN;Initial Catalog=Arac_Kiralama_Final1;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Personel where Yetkili_Ad='" + YetkiliTxt.Text + "' and Yetkili_Sifre='" + YetkiliPswTxt.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ İŞLEMİ BAŞARILI SAYFAYA YÖNLENDİRİLİYORSUNUZ.." + " - " + YetkiliTxt.Text + " - ");
                Form BaslangıcForm = new AdminAnaSayfa();
                BaslangıcForm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("LÜTFEN GİRİŞ BİLGİLERİNİZİ KONTROL EDİNİZ");
            }
            con.Close();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
