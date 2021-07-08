
namespace AraçKiralamaOtomasyonu
{
    partial class FirmaBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtbn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.AdresLbl = new System.Windows.Forms.Label();
            this.CalısanSayısıLbl = new System.Windows.Forms.Label();
            this.TelefonLbl = new System.Windows.Forms.Label();
            this.CalısanSayısıTxt = new System.Windows.Forms.TextBox();
            this.AdresTxt = new System.Windows.Forms.TextBox();
            this.TelefonMskbx = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TemizleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.Chocolate;
            this.EkleBtn.Location = new System.Drawing.Point(40, 313);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(75, 53);
            this.EkleBtn.TabIndex = 1;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtbn
            // 
            this.SilBtbn.BackColor = System.Drawing.Color.Chocolate;
            this.SilBtbn.Location = new System.Drawing.Point(357, 313);
            this.SilBtbn.Name = "SilBtbn";
            this.SilBtbn.Size = new System.Drawing.Size(94, 53);
            this.SilBtbn.TabIndex = 2;
            this.SilBtbn.Text = "SİL";
            this.SilBtbn.UseVisualStyleBackColor = false;
            this.SilBtbn.Click += new System.EventHandler(this.SilBtbn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.Chocolate;
            this.GuncelleBtn.Location = new System.Drawing.Point(226, 313);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(125, 53);
            this.GuncelleBtn.TabIndex = 3;
            this.GuncelleBtn.Text = "GÜNCELLE";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ListeleBtn.Location = new System.Drawing.Point(121, 313);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(99, 53);
            this.ListeleBtn.TabIndex = 4;
            this.ListeleBtn.Text = "LİSTELE";
            this.ListeleBtn.UseVisualStyleBackColor = false;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.Color.Red;
            this.GeriBtn.Location = new System.Drawing.Point(457, 313);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(75, 53);
            this.GeriBtn.TabIndex = 5;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // AdresLbl
            // 
            this.AdresLbl.AutoSize = true;
            this.AdresLbl.BackColor = System.Drawing.Color.Transparent;
            this.AdresLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdresLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.AdresLbl.Location = new System.Drawing.Point(28, 122);
            this.AdresLbl.Name = "AdresLbl";
            this.AdresLbl.Size = new System.Drawing.Size(74, 24);
            this.AdresLbl.TabIndex = 7;
            this.AdresLbl.Text = "ADRES";
            // 
            // CalısanSayısıLbl
            // 
            this.CalısanSayısıLbl.AutoSize = true;
            this.CalısanSayısıLbl.BackColor = System.Drawing.Color.Transparent;
            this.CalısanSayısıLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalısanSayısıLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CalısanSayısıLbl.Location = new System.Drawing.Point(28, 234);
            this.CalısanSayısıLbl.Name = "CalısanSayısıLbl";
            this.CalısanSayısıLbl.Size = new System.Drawing.Size(163, 24);
            this.CalısanSayısıLbl.TabIndex = 8;
            this.CalısanSayısıLbl.Text = "ÇALIŞSAN SAYISI";
            // 
            // TelefonLbl
            // 
            this.TelefonLbl.AutoSize = true;
            this.TelefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.TelefonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TelefonLbl.Location = new System.Drawing.Point(28, 178);
            this.TelefonLbl.Name = "TelefonLbl";
            this.TelefonLbl.Size = new System.Drawing.Size(99, 24);
            this.TelefonLbl.TabIndex = 9;
            this.TelefonLbl.Text = "TELEFON";
            // 
            // CalısanSayısıTxt
            // 
            this.CalısanSayısıTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalısanSayısıTxt.Location = new System.Drawing.Point(272, 232);
            this.CalısanSayısıTxt.Name = "CalısanSayısıTxt";
            this.CalısanSayısıTxt.Size = new System.Drawing.Size(141, 28);
            this.CalısanSayısıTxt.TabIndex = 11;
            // 
            // AdresTxt
            // 
            this.AdresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdresTxt.Location = new System.Drawing.Point(272, 118);
            this.AdresTxt.Name = "AdresTxt";
            this.AdresTxt.Size = new System.Drawing.Size(141, 28);
            this.AdresTxt.TabIndex = 13;
            // 
            // TelefonMskbx
            // 
            this.TelefonMskbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonMskbx.Location = new System.Drawing.Point(272, 178);
            this.TelefonMskbx.Mask = "(999) 000-0000";
            this.TelefonMskbx.Name = "TelefonMskbx";
            this.TelefonMskbx.Size = new System.Drawing.Size(141, 28);
            this.TelefonMskbx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "MERAM OTO KİRALAMA BAYİ BİLGİLERİ";
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.BackColor = System.Drawing.Color.Chocolate;
            this.TemizleBtn.Location = new System.Drawing.Point(448, 164);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(84, 61);
            this.TemizleBtn.TabIndex = 18;
            this.TemizleBtn.Text = "TEMİZLE";
            this.TemizleBtn.UseVisualStyleBackColor = false;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // FirmaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AraçKiralamaOtomasyonu.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 592);
            this.Controls.Add(this.TemizleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelefonMskbx);
            this.Controls.Add(this.AdresTxt);
            this.Controls.Add(this.CalısanSayısıTxt);
            this.Controls.Add(this.TelefonLbl);
            this.Controls.Add(this.CalısanSayısıLbl);
            this.Controls.Add(this.AdresLbl);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.ListeleBtn);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtbn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(583, 639);
            this.MinimumSize = new System.Drawing.Size(583, 639);
            this.Name = "FirmaBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirmaBilgileri";
            this.Load += new System.EventHandler(this.FirmaBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtbn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Label AdresLbl;
        private System.Windows.Forms.Label CalısanSayısıLbl;
        private System.Windows.Forms.Label TelefonLbl;
        private System.Windows.Forms.TextBox CalısanSayısıTxt;
        private System.Windows.Forms.TextBox AdresTxt;
        private System.Windows.Forms.MaskedTextBox TelefonMskbx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TemizleBtn;
    }
}