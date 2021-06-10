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

        private void CıkısBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

     

        private void AraclarBtn1_Click(object sender, EventArgs e)
        {
            Form AracForm = new AracForm();
            AracForm.ShowDialog();
        }

        private void FirmaBilgileriBtn_Click(object sender, EventArgs e)
        {
            Form FirmaBilgileri = new FirmaBilgileri();
            FirmaBilgileri.ShowDialog();
        }
    }
}
