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
    public partial class KullanıcıAnsayfa : Form
    {
        public KullanıcıAnsayfa()
        {
            InitializeComponent();
        }

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AraclarBtn1_MouseHover(object sender, EventArgs e)
        {
            this.AraclarBtn1.BackColor = System.Drawing.Color.Green;
        }

        private void AraclarBtn1_MouseLeave(object sender, EventArgs e)
        {
            this.AraclarBtn1.BackColor = System.Drawing.Color.Transparent;
        }

        private void AracKiralaBtn_MouseHover(object sender, EventArgs e)
        {
            this.AracKiralaBtn.BackColor = System.Drawing.Color.Green;
        }

        private void AracKiralaBtn_MouseLeave(object sender, EventArgs e)
        {
            this.AracKiralaBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void CıkısBtn_MouseHover(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Red;
        }

        private void CıkısBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CıkısBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void YardımBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detaylı Bilgi İçin Lütfen İletişime Geçiniz\n011122214\nMERAM OTO KİRALAMA");
        }

        private void AracKiralaBtn_Click(object sender, EventArgs e)
        {
            Form SozlesmeYap = new Sözleşme_Yap();
            SozlesmeYap.ShowDialog();
        }

        private void AraclarBtn1_Click(object sender, EventArgs e)
        {
            Form AracListe = new AracListe();
            AracListe.ShowDialog();
        }
    }

    }

