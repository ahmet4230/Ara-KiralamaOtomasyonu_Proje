
namespace AraçKiralamaOtomasyonu
{
    partial class KullanıcıAnsayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıAnsayfa));
            this.AraclarBtn1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AracKiralaBtn = new System.Windows.Forms.Button();
            this.CıkısBtn = new System.Windows.Forms.Button();
            this.YardımBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AraclarBtn1
            // 
            this.AraclarBtn1.BackColor = System.Drawing.Color.Transparent;
            this.AraclarBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AraclarBtn1.BackgroundImage")));
            this.AraclarBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AraclarBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraclarBtn1.ForeColor = System.Drawing.Color.Black;
            this.AraclarBtn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AraclarBtn1.ImageIndex = 0;
            this.AraclarBtn1.ImageList = this.ımageList1;
            this.AraclarBtn1.Location = new System.Drawing.Point(13, 12);
            this.AraclarBtn1.Name = "AraclarBtn1";
            this.AraclarBtn1.Size = new System.Drawing.Size(745, 93);
            this.AraclarBtn1.TabIndex = 1;
            this.AraclarBtn1.Text = "ARAÇLAR";
            this.AraclarBtn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AraclarBtn1.UseVisualStyleBackColor = false;
            this.AraclarBtn1.MouseLeave += new System.EventHandler(this.AraclarBtn1_MouseLeave);
            this.AraclarBtn1.MouseHover += new System.EventHandler(this.AraclarBtn1_MouseHover);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (7).png");
            this.ımageList1.Images.SetKeyName(1, "indir (6) (1).png");
            this.ımageList1.Images.SetKeyName(2, "1024px-Crystal_Clear_action_exit.svg.png");
            this.ımageList1.Images.SetKeyName(3, "indir (4) (1).png");
            // 
            // AracKiralaBtn
            // 
            this.AracKiralaBtn.BackColor = System.Drawing.Color.Transparent;
            this.AracKiralaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AracKiralaBtn.BackgroundImage")));
            this.AracKiralaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AracKiralaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracKiralaBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AracKiralaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AracKiralaBtn.ImageIndex = 1;
            this.AracKiralaBtn.ImageList = this.ımageList1;
            this.AracKiralaBtn.Location = new System.Drawing.Point(13, 179);
            this.AracKiralaBtn.Name = "AracKiralaBtn";
            this.AracKiralaBtn.Size = new System.Drawing.Size(745, 92);
            this.AracKiralaBtn.TabIndex = 5;
            this.AracKiralaBtn.Text = "ARAÇ KİRALA";
            this.AracKiralaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AracKiralaBtn.UseVisualStyleBackColor = false;
            this.AracKiralaBtn.MouseLeave += new System.EventHandler(this.AracKiralaBtn_MouseLeave);
            this.AracKiralaBtn.MouseHover += new System.EventHandler(this.AracKiralaBtn_MouseHover);
            // 
            // CıkısBtn
            // 
            this.CıkısBtn.BackColor = System.Drawing.Color.Transparent;
            this.CıkısBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CıkısBtn.BackgroundImage")));
            this.CıkısBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CıkısBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CıkısBtn.ForeColor = System.Drawing.Color.Black;
            this.CıkısBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CıkısBtn.ImageIndex = 2;
            this.CıkısBtn.ImageList = this.ımageList1;
            this.CıkısBtn.Location = new System.Drawing.Point(13, 517);
            this.CıkısBtn.Name = "CıkısBtn";
            this.CıkısBtn.Size = new System.Drawing.Size(745, 102);
            this.CıkısBtn.TabIndex = 6;
            this.CıkısBtn.Text = "ÇIKIŞ";
            this.CıkısBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CıkısBtn.UseVisualStyleBackColor = false;
            this.CıkısBtn.Click += new System.EventHandler(this.CıkısBtn_Click);
            this.CıkısBtn.MouseLeave += new System.EventHandler(this.CıkısBtn_MouseLeave);
            this.CıkısBtn.MouseHover += new System.EventHandler(this.CıkısBtn_MouseHover);
            // 
            // YardımBtn
            // 
            this.YardımBtn.BackColor = System.Drawing.Color.Transparent;
            this.YardımBtn.BackgroundImage = global::AraçKiralamaOtomasyonu.Properties.Resources.images;
            this.YardımBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YardımBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.YardımBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YardımBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YardımBtn.ImageIndex = 3;
            this.YardımBtn.ImageList = this.ımageList1;
            this.YardımBtn.Location = new System.Drawing.Point(12, 345);
            this.YardımBtn.Name = "YardımBtn";
            this.YardımBtn.Size = new System.Drawing.Size(745, 98);
            this.YardımBtn.TabIndex = 7;
            this.YardımBtn.Text = "YARDIM";
            this.YardımBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.YardımBtn.UseVisualStyleBackColor = false;
            this.YardımBtn.Click += new System.EventHandler(this.YardımBtn_Click);
            // 
            // KullanıcıAnsayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 663);
            this.Controls.Add(this.YardımBtn);
            this.Controls.Add(this.CıkısBtn);
            this.Controls.Add(this.AracKiralaBtn);
            this.Controls.Add(this.AraclarBtn1);
            this.MaximumSize = new System.Drawing.Size(788, 710);
            this.MinimumSize = new System.Drawing.Size(788, 710);
            this.Name = "KullanıcıAnsayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıAnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AraclarBtn1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button AracKiralaBtn;
        private System.Windows.Forms.Button CıkısBtn;
        private System.Windows.Forms.Button YardımBtn;
    }
}