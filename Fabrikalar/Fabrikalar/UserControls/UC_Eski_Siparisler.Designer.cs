namespace Fabrikalar.UserControls
{
    partial class UC_Eski_Siparisler
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.firma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYemek_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toplam_adet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brm_ucret = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.duzenleme_baslik = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.duzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(358, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(771, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(266, 356);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(491, 77);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // firma
            // 
            this.firma.AutoSize = true;
            this.firma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.firma.Location = new System.Drawing.Point(62, 33);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(77, 19);
            this.firma.TabIndex = 29;
            this.firma.Text = "Firmanın";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(617, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 55);
            this.button1.TabIndex = 31;
            this.button1.Text = "Siparişi Sil";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYemek_Ekle
            // 
            this.btnYemek_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnYemek_Ekle.FlatAppearance.BorderSize = 0;
            this.btnYemek_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYemek_Ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemek_Ekle.ForeColor = System.Drawing.Color.White;
            this.btnYemek_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYemek_Ekle.Location = new System.Drawing.Point(470, 378);
            this.btnYemek_Ekle.Name = "btnYemek_Ekle";
            this.btnYemek_Ekle.Size = new System.Drawing.Size(116, 55);
            this.btnYemek_Ekle.TabIndex = 30;
            this.btnYemek_Ekle.Text = "Siparişi Düzenle";
            this.btnYemek_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYemek_Ekle.UseVisualStyleBackColor = false;
            this.btnYemek_Ekle.Click += new System.EventHandler(this.btnYemek_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Toplam Adet";
            // 
            // toplam_adet
            // 
            this.toplam_adet.AutoSize = true;
            this.toplam_adet.Location = new System.Drawing.Point(924, 436);
            this.toplam_adet.Name = "toplam_adet";
            this.toplam_adet.Size = new System.Drawing.Size(59, 21);
            this.toplam_adet.TabIndex = 33;
            this.toplam_adet.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Birim Ücret";
            // 
            // brm_ucret
            // 
            this.brm_ucret.AutoSize = true;
            this.brm_ucret.Location = new System.Drawing.Point(924, 471);
            this.brm_ucret.Name = "brm_ucret";
            this.brm_ucret.Size = new System.Drawing.Size(53, 21);
            this.brm_ucret.TabIndex = 35;
            this.brm_ucret.Text = "Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Aylık Tutar";
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Location = new System.Drawing.Point(926, 497);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(51, 21);
            this.tutar.TabIndex = 37;
            this.tutar.Text = "Tutar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(771, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 3);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(771, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 3);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(895, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 80);
            this.panel4.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(771, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 39);
            this.button2.TabIndex = 42;
            this.button2.Text = "Çıktı Al";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // duzenle
            // 
            this.duzenle.Controls.Add(this.label4);
            this.duzenle.Controls.Add(this.dataGridView3);
            this.duzenle.Controls.Add(this.duzenleme_baslik);
            this.duzenle.Controls.Add(this.panel3);
            this.duzenle.Controls.Add(this.flowLayoutPanel3);
            this.duzenle.Controls.Add(this.flowLayoutPanel2);
            this.duzenle.Controls.Add(this.flowLayoutPanel1);
            this.duzenle.Controls.Add(this.btn_kaydet);
            this.duzenle.Controls.Add(this.btn_iptal);
            this.duzenle.ForeColor = System.Drawing.Color.Black;
            this.duzenle.Location = new System.Drawing.Point(54, 77);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(391, 486);
            this.duzenle.TabIndex = 43;
            this.duzenle.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(53, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tarih\' te değişiklik yapmayınız";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(57, 54);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(266, 302);
            this.dataGridView3.TabIndex = 47;
            // 
            // duzenleme_baslik
            // 
            this.duzenleme_baslik.AutoSize = true;
            this.duzenleme_baslik.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenleme_baslik.ForeColor = System.Drawing.Color.Black;
            this.duzenleme_baslik.Location = new System.Drawing.Point(53, 18);
            this.duzenleme_baslik.Name = "duzenleme_baslik";
            this.duzenleme_baslik.Size = new System.Drawing.Size(148, 19);
            this.duzenleme_baslik.TabIndex = 46;
            this.duzenleme_baslik.Text = "Düzenleme Ekranı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(388, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 483);
            this.panel3.TabIndex = 45;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(3, 483);
            this.flowLayoutPanel3.TabIndex = 44;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(10, 0);
            this.flowLayoutPanel4.TabIndex = 45;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 483);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(391, 3);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 3);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(204, 406);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(119, 55);
            this.btn_kaydet.TabIndex = 33;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Red;
            this.btn_iptal.FlatAppearance.BorderSize = 0;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iptal.Location = new System.Drawing.Point(57, 406);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(116, 55);
            this.btn_iptal.TabIndex = 32;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // UC_Eski_Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brm_ucret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toplam_adet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYemek_Ekle);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Eski_Siparisler";
            this.Size = new System.Drawing.Size(1081, 580);
            this.Load += new System.EventHandler(this.UC_Eski_Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.duzenle.ResumeLayout(false);
            this.duzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label firma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYemek_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toplam_adet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label brm_ucret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel duzenle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label duzenleme_baslik;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
    }
}
