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
    public partial class AdminAnaSayfa : Form
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void BaslangıcForm_Load(object sender, EventArgs e)
        {

        }

        private void MusterılerBtn_Click(object sender, EventArgs e)
        {
            Form Musteriler = new MusterileBilgileri();
            Musteriler.ShowDialog();
        }

        private void KullanıcılarBtn_Click(object sender, EventArgs e)
        {
            Form Kullanıcılar = new KullanıcılarForm();
            Kullanıcılar.ShowDialog();
           
        }

        


        private void KullanıcılarBtn_MouseHover(object sender, EventArgs e)
        {
            this.KullanıcılarBtn.BackColor = System.Drawing.Color.Red;
        }

        private void KullanıcılarBtn_MouseLeave(object sender, EventArgs e)
        {
            this.KullanıcılarBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void MusterılerBtn_MouseHover(object sender, EventArgs e)
        {
            this.MusterılerBtn.BackColor = System.Drawing.Color.Red;
        }

        private void MusterılerBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MusterılerBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void AraclarBtn1_MouseHover(object sender, EventArgs e)
        {
            this.AraclarBtn1.BackColor = System.Drawing.Color.Red;
        }

        private void AraclarBtn1_MouseLeave(object sender, EventArgs e)
        {
            this.AraclarBtn1.BackColor = System.Drawing.Color.Transparent;
        }

        
        private void MusteriEklemeBtn_MouseHover(object sender, EventArgs e)
        {
            this.MusteriEklemeBtn.BackColor = System.Drawing.Color.Red;
        }

        private void MusteriEklemeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MusteriEklemeBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void CıkısBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       

      
        private void CıkısBtn_MouseHover(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Red;
        }

        private void CıkısBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void MusteriEklemeBtn_Click(object sender, EventArgs e)
        {
            Form MusteriEkleme = new MusteriEklemeForm();
            MusteriEkleme.ShowDialog();
        }

        private void AracEklemeBtn_Click(object sender, EventArgs e)
        {
            Form AracForm = new AracForm();
            AracForm.ShowDialog();
        }

        private void YardımBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AraclarBtn1_Click(object sender, EventArgs e)
        {
            Form AracForm = new AracForm();
            AracForm.ShowDialog();
        }
    }
}
