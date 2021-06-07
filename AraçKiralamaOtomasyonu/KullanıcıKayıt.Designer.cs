
namespace AraçKiralamaOtomasyonu
{
    partial class KullanıcıKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EkleBtn = new System.Windows.Forms.Button();
            this.CıkısBtn = new System.Windows.Forms.Button();
            this.KullanıcıİsimTxt = new System.Windows.Forms.Label();
            this.KullanıcıSifre = new System.Windows.Forms.Label();
            this.KullanıcıİsimTxt1 = new System.Windows.Forms.TextBox();
            this.KullanıcıSifreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EkleBtn
            // 
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.Location = new System.Drawing.Point(95, 337);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(103, 79);
            this.EkleBtn.TabIndex = 0;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            this.EkleBtn.MouseLeave += new System.EventHandler(this.EkleBtn_MouseLeave);
            this.EkleBtn.MouseHover += new System.EventHandler(this.EkleBtn_MouseHover);
            // 
            // CıkısBtn
            // 
            this.CıkısBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.CıkısBtn.Location = new System.Drawing.Point(348, 337);
            this.CıkısBtn.Name = "CıkısBtn";
            this.CıkısBtn.Size = new System.Drawing.Size(103, 79);
            this.CıkısBtn.TabIndex = 1;
            this.CıkısBtn.Text = "ÇIKIŞ";
            this.CıkısBtn.UseVisualStyleBackColor = true;
            this.CıkısBtn.Click += new System.EventHandler(this.CıkısBtn_Click_1);
            this.CıkısBtn.MouseLeave += new System.EventHandler(this.CıkısBtn_MouseLeave);
            this.CıkısBtn.MouseHover += new System.EventHandler(this.CıkısBtn_MouseHover);
            // 
            // KullanıcıİsimTxt
            // 
            this.KullanıcıİsimTxt.AutoSize = true;
            this.KullanıcıİsimTxt.BackColor = System.Drawing.Color.Transparent;
            this.KullanıcıİsimTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıİsimTxt.Location = new System.Drawing.Point(12, 122);
            this.KullanıcıİsimTxt.Name = "KullanıcıİsimTxt";
            this.KullanıcıİsimTxt.Size = new System.Drawing.Size(222, 32);
            this.KullanıcıİsimTxt.TabIndex = 2;
            this.KullanıcıİsimTxt.Text = "KULLANICI İSİM";
            // 
            // KullanıcıSifre
            // 
            this.KullanıcıSifre.AutoSize = true;
            this.KullanıcıSifre.BackColor = System.Drawing.Color.Transparent;
            this.KullanıcıSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.KullanıcıSifre.Location = new System.Drawing.Point(12, 235);
            this.KullanıcıSifre.Name = "KullanıcıSifre";
            this.KullanıcıSifre.Size = new System.Drawing.Size(248, 32);
            this.KullanıcıSifre.TabIndex = 3;
            this.KullanıcıSifre.Text = "KULLANICI ŞİFRE";
            // 
            // KullanıcıİsimTxt1
            // 
            this.KullanıcıİsimTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıİsimTxt1.Location = new System.Drawing.Point(315, 116);
            this.KullanıcıİsimTxt1.Name = "KullanıcıİsimTxt1";
            this.KullanıcıİsimTxt1.Size = new System.Drawing.Size(204, 38);
            this.KullanıcıİsimTxt1.TabIndex = 4;
            // 
            // KullanıcıSifreTxt
            // 
            this.KullanıcıSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.KullanıcıSifreTxt.Location = new System.Drawing.Point(315, 229);
            this.KullanıcıSifreTxt.Name = "KullanıcıSifreTxt";
            this.KullanıcıSifreTxt.PasswordChar = '*';
            this.KullanıcıSifreTxt.Size = new System.Drawing.Size(204, 38);
            this.KullanıcıSifreTxt.TabIndex = 5;
            // 
            // KullanıcıKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AraçKiralamaOtomasyonu.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.KullanıcıSifreTxt);
            this.Controls.Add(this.KullanıcıİsimTxt1);
            this.Controls.Add(this.KullanıcıSifre);
            this.Controls.Add(this.KullanıcıİsimTxt);
            this.Controls.Add(this.CıkısBtn);
            this.Controls.Add(this.EkleBtn);
            this.Name = "KullanıcıKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KullanıcıKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button CıkısBtn;
        private System.Windows.Forms.Label KullanıcıİsimTxt;
        private System.Windows.Forms.Label KullanıcıSifre;
        private System.Windows.Forms.TextBox KullanıcıİsimTxt1;
        private System.Windows.Forms.TextBox KullanıcıSifreTxt;
    }
}