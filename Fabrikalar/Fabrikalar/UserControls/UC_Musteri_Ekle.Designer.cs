namespace Fabrikalar.UserControls
{
    partial class UC_Musteri_Ekle
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_musteri_ekle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_firma_adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteri_Ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_firma_adi = new System.Windows.Forms.TextBox();
            this.txt_firma_telefon = new System.Windows.Forms.MaskedTextBox();
            this.pnl_guncelle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_gcl_iptal = new System.Windows.Forms.Button();
            this.txt_gncl_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_gncl_adres = new System.Windows.Forms.TextBox();
            this.txt_gncl_firma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_gcl_kaydet = new System.Windows.Forms.Button();
            this.pnl_musteri_ekle.SuspendLayout();
            this.pnl_guncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numara,
            this.Firma,
            this.Telefon,
            this.Adres});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(53, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(649, 374);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Numara
            // 
            this.Numara.Text = "No";
            // 
            // Firma
            // 
            this.Firma.Text = "Firma";
            this.Firma.Width = 195;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 124;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 258;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(273, 497);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(119, 55);
            this.btn_sil.TabIndex = 33;
            this.btn_sil.Text = "Müşteri Sil";
            this.btn_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(408, 497);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(137, 55);
            this.btn_guncelle.TabIndex = 32;
            this.btn_guncelle.Text = "Müşteri Bilgileri Güncelle";
            this.btn_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(565, 497);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(137, 55);
            this.btn_ekle.TabIndex = 34;
            this.btn_ekle.Text = "Müşteri Ekle";
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Müşteri Bilgileri";
            // 
            // pnl_musteri_ekle
            // 
            this.pnl_musteri_ekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_musteri_ekle.Controls.Add(this.label5);
            this.pnl_musteri_ekle.Controls.Add(this.button1);
            this.pnl_musteri_ekle.Controls.Add(this.txt_firma_adres);
            this.pnl_musteri_ekle.Controls.Add(this.label2);
            this.pnl_musteri_ekle.Controls.Add(this.btnMusteri_Ekle);
            this.pnl_musteri_ekle.Controls.Add(this.label3);
            this.pnl_musteri_ekle.Controls.Add(this.label4);
            this.pnl_musteri_ekle.Controls.Add(this.txt_firma_adi);
            this.pnl_musteri_ekle.Controls.Add(this.txt_firma_telefon);
            this.pnl_musteri_ekle.Location = new System.Drawing.Point(710, 104);
            this.pnl_musteri_ekle.Name = "pnl_musteri_ekle";
            this.pnl_musteri_ekle.Size = new System.Drawing.Size(341, 374);
            this.pnl_musteri_ekle.TabIndex = 36;
            this.pnl_musteri_ekle.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(81, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Müşteri Ekleme Ekranı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(145, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "İptal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_firma_adres
            // 
            this.txt_firma_adres.Location = new System.Drawing.Point(145, 182);
            this.txt_firma_adres.Multiline = true;
            this.txt_firma_adres.Name = "txt_firma_adres";
            this.txt_firma_adres.Size = new System.Drawing.Size(180, 105);
            this.txt_firma_adres.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Firma Adı";
            // 
            // btnMusteri_Ekle
            // 
            this.btnMusteri_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnMusteri_Ekle.FlatAppearance.BorderSize = 0;
            this.btnMusteri_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri_Ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri_Ekle.ForeColor = System.Drawing.Color.White;
            this.btnMusteri_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri_Ekle.Location = new System.Drawing.Point(242, 308);
            this.btnMusteri_Ekle.Name = "btnMusteri_Ekle";
            this.btnMusteri_Ekle.Size = new System.Drawing.Size(80, 41);
            this.btnMusteri_Ekle.TabIndex = 31;
            this.btnMusteri_Ekle.Text = "Kaydet";
            this.btnMusteri_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri_Ekle.UseVisualStyleBackColor = false;
            this.btnMusteri_Ekle.Click += new System.EventHandler(this.btnMusteri_Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Adres";
            // 
            // txt_firma_adi
            // 
            this.txt_firma_adi.Location = new System.Drawing.Point(145, 68);
            this.txt_firma_adi.Name = "txt_firma_adi";
            this.txt_firma_adi.Size = new System.Drawing.Size(177, 27);
            this.txt_firma_adi.TabIndex = 28;
            // 
            // txt_firma_telefon
            // 
            this.txt_firma_telefon.Location = new System.Drawing.Point(145, 131);
            this.txt_firma_telefon.Mask = "(999) 000-0000";
            this.txt_firma_telefon.Name = "txt_firma_telefon";
            this.txt_firma_telefon.Size = new System.Drawing.Size(123, 27);
            this.txt_firma_telefon.TabIndex = 29;
            // 
            // pnl_guncelle
            // 
            this.pnl_guncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_guncelle.Controls.Add(this.label6);
            this.pnl_guncelle.Controls.Add(this.label9);
            this.pnl_guncelle.Controls.Add(this.btn_gcl_iptal);
            this.pnl_guncelle.Controls.Add(this.txt_gncl_tel);
            this.pnl_guncelle.Controls.Add(this.txt_gncl_adres);
            this.pnl_guncelle.Controls.Add(this.txt_gncl_firma);
            this.pnl_guncelle.Controls.Add(this.label7);
            this.pnl_guncelle.Controls.Add(this.label8);
            this.pnl_guncelle.Controls.Add(this.btn_gcl_kaydet);
            this.pnl_guncelle.Location = new System.Drawing.Point(708, 108);
            this.pnl_guncelle.Name = "pnl_guncelle";
            this.pnl_guncelle.Size = new System.Drawing.Size(343, 368);
            this.pnl_guncelle.TabIndex = 37;
            this.pnl_guncelle.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Müşteri Güncelleme Ekranı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Adres";
            // 
            // btn_gcl_iptal
            // 
            this.btn_gcl_iptal.BackColor = System.Drawing.Color.Red;
            this.btn_gcl_iptal.FlatAppearance.BorderSize = 0;
            this.btn_gcl_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gcl_iptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gcl_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_gcl_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gcl_iptal.Location = new System.Drawing.Point(156, 312);
            this.btn_gcl_iptal.Name = "btn_gcl_iptal";
            this.btn_gcl_iptal.Size = new System.Drawing.Size(84, 41);
            this.btn_gcl_iptal.TabIndex = 41;
            this.btn_gcl_iptal.Text = "İptal";
            this.btn_gcl_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gcl_iptal.UseVisualStyleBackColor = false;
            this.btn_gcl_iptal.Click += new System.EventHandler(this.btn_gcl_iptal_Click);
            // 
            // txt_gncl_tel
            // 
            this.txt_gncl_tel.Location = new System.Drawing.Point(156, 135);
            this.txt_gncl_tel.Mask = "(999) 000-0000";
            this.txt_gncl_tel.Name = "txt_gncl_tel";
            this.txt_gncl_tel.Size = new System.Drawing.Size(123, 27);
            this.txt_gncl_tel.TabIndex = 38;
            // 
            // txt_gncl_adres
            // 
            this.txt_gncl_adres.Location = new System.Drawing.Point(156, 186);
            this.txt_gncl_adres.Multiline = true;
            this.txt_gncl_adres.Name = "txt_gncl_adres";
            this.txt_gncl_adres.Size = new System.Drawing.Size(180, 105);
            this.txt_gncl_adres.TabIndex = 39;
            // 
            // txt_gncl_firma
            // 
            this.txt_gncl_firma.Location = new System.Drawing.Point(156, 72);
            this.txt_gncl_firma.Name = "txt_gncl_firma";
            this.txt_gncl_firma.Size = new System.Drawing.Size(177, 27);
            this.txt_gncl_firma.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Firma Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefon Numarası";
            // 
            // btn_gcl_kaydet
            // 
            this.btn_gcl_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_gcl_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_gcl_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gcl_kaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gcl_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_gcl_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gcl_kaydet.Location = new System.Drawing.Point(253, 312);
            this.btn_gcl_kaydet.Name = "btn_gcl_kaydet";
            this.btn_gcl_kaydet.Size = new System.Drawing.Size(80, 41);
            this.btn_gcl_kaydet.TabIndex = 40;
            this.btn_gcl_kaydet.Text = "Kaydet";
            this.btn_gcl_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gcl_kaydet.UseVisualStyleBackColor = false;
            this.btn_gcl_kaydet.Click += new System.EventHandler(this.btn_gcl_kaydet_Click);
            // 
            // UC_Musteri_Ekle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_guncelle);
            this.Controls.Add(this.pnl_musteri_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Musteri_Ekle";
            this.Size = new System.Drawing.Size(1051, 580);
            this.Load += new System.EventHandler(this.UC_Musteri_Ekle_Load);
            this.pnl_musteri_ekle.ResumeLayout(false);
            this.pnl_musteri_ekle.PerformLayout();
            this.pnl_guncelle.ResumeLayout(false);
            this.pnl_guncelle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numara;
        private System.Windows.Forms.ColumnHeader Firma;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_musteri_ekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_firma_adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusteri_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_firma_adi;
        private System.Windows.Forms.MaskedTextBox txt_firma_telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_gncl_tel;
        private System.Windows.Forms.TextBox txt_gncl_adres;
        private System.Windows.Forms.TextBox txt_gncl_firma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_gcl_iptal;
        private System.Windows.Forms.Button btn_gcl_kaydet;
    }
}
