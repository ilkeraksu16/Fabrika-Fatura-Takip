namespace Fabrikalar.UserControls
{
    partial class UC_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ayarlar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_birim_fiyat = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.pnl_degistir_ekrani = new System.Windows.Forms.Panel();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_birim_kaydet = new System.Windows.Forms.Button();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_fatura_kaynak = new System.Windows.Forms.Label();
            this.btn_fatura_kaynak_degistir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_fatura_hedef = new System.Windows.Forms.Button();
            this.lbl_hedef_adres = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_degistir_ekrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(99, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ayarlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyat:";
            // 
            // lbl_birim_fiyat
            // 
            this.lbl_birim_fiyat.AutoSize = true;
            this.lbl_birim_fiyat.Location = new System.Drawing.Point(208, 155);
            this.lbl_birim_fiyat.Name = "lbl_birim_fiyat";
            this.lbl_birim_fiyat.Size = new System.Drawing.Size(32, 21);
            this.lbl_birim_fiyat.TabIndex = 2;
            this.lbl_birim_fiyat.Text = "0 ₺";
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_degistir.FlatAppearance.BorderSize = 0;
            this.btn_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_degistir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_degistir.ForeColor = System.Drawing.Color.White;
            this.btn_degistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_degistir.Location = new System.Drawing.Point(368, 146);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(156, 38);
            this.btn_degistir.TabIndex = 35;
            this.btn_degistir.Text = "Birim Fiyat Değiştir";
            this.btn_degistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_degistir.UseVisualStyleBackColor = false;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // pnl_degistir_ekrani
            // 
            this.pnl_degistir_ekrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_degistir_ekrani.Controls.Add(this.btn_iptal);
            this.pnl_degistir_ekrani.Controls.Add(this.btn_birim_kaydet);
            this.pnl_degistir_ekrani.Controls.Add(this.txt_birim);
            this.pnl_degistir_ekrani.Controls.Add(this.label4);
            this.pnl_degistir_ekrani.Controls.Add(this.label3);
            this.pnl_degistir_ekrani.Location = new System.Drawing.Point(592, 68);
            this.pnl_degistir_ekrani.Name = "pnl_degistir_ekrani";
            this.pnl_degistir_ekrani.Size = new System.Drawing.Size(276, 177);
            this.pnl_degistir_ekrani.TabIndex = 36;
            this.pnl_degistir_ekrani.Visible = false;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Red;
            this.btn_iptal.FlatAppearance.BorderSize = 0;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iptal.Location = new System.Drawing.Point(43, 118);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(84, 41);
            this.btn_iptal.TabIndex = 43;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_birim_kaydet
            // 
            this.btn_birim_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_birim_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_birim_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_birim_kaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_birim_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_birim_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_birim_kaydet.Location = new System.Drawing.Point(151, 118);
            this.btn_birim_kaydet.Name = "btn_birim_kaydet";
            this.btn_birim_kaydet.Size = new System.Drawing.Size(80, 41);
            this.btn_birim_kaydet.TabIndex = 42;
            this.btn_birim_kaydet.Text = "Kaydet";
            this.btn_birim_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_birim_kaydet.UseVisualStyleBackColor = false;
            this.btn_birim_kaydet.Click += new System.EventHandler(this.btn_birim_kaydet_Click);
            // 
            // txt_birim
            // 
            this.txt_birim.Location = new System.Drawing.Point(151, 64);
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(107, 27);
            this.txt_birim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birim Fiyat Değiştirme Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yeni Birim Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Fatura Formatı Kaynak Adresi:";
            // 
            // lbl_fatura_kaynak
            // 
            this.lbl_fatura_kaynak.AutoSize = true;
            this.lbl_fatura_kaynak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fatura_kaynak.Location = new System.Drawing.Point(102, 283);
            this.lbl_fatura_kaynak.Name = "lbl_fatura_kaynak";
            this.lbl_fatura_kaynak.Size = new System.Drawing.Size(0, 19);
            this.lbl_fatura_kaynak.TabIndex = 38;
            // 
            // btn_fatura_kaynak_degistir
            // 
            this.btn_fatura_kaynak_degistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_fatura_kaynak_degistir.FlatAppearance.BorderSize = 0;
            this.btn_fatura_kaynak_degistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fatura_kaynak_degistir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura_kaynak_degistir.ForeColor = System.Drawing.Color.White;
            this.btn_fatura_kaynak_degistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fatura_kaynak_degistir.Location = new System.Drawing.Point(368, 246);
            this.btn_fatura_kaynak_degistir.Name = "btn_fatura_kaynak_degistir";
            this.btn_fatura_kaynak_degistir.Size = new System.Drawing.Size(112, 38);
            this.btn_fatura_kaynak_degistir.TabIndex = 39;
            this.btn_fatura_kaynak_degistir.Text = "Değiştir";
            this.btn_fatura_kaynak_degistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fatura_kaynak_degistir.UseVisualStyleBackColor = false;
            this.btn_fatura_kaynak_degistir.Click += new System.EventHandler(this.btn_fatura_kaynak_degistir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fatura Hedef Adresi:";
            // 
            // btn_fatura_hedef
            // 
            this.btn_fatura_hedef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_fatura_hedef.FlatAppearance.BorderSize = 0;
            this.btn_fatura_hedef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fatura_hedef.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura_hedef.ForeColor = System.Drawing.Color.White;
            this.btn_fatura_hedef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fatura_hedef.Location = new System.Drawing.Point(368, 347);
            this.btn_fatura_hedef.Name = "btn_fatura_hedef";
            this.btn_fatura_hedef.Size = new System.Drawing.Size(112, 38);
            this.btn_fatura_hedef.TabIndex = 41;
            this.btn_fatura_hedef.Text = "Değiştir";
            this.btn_fatura_hedef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fatura_hedef.UseVisualStyleBackColor = false;
            this.btn_fatura_hedef.Click += new System.EventHandler(this.btn_fatura_hedef_Click);
            // 
            // lbl_hedef_adres
            // 
            this.lbl_hedef_adres.AutoSize = true;
            this.lbl_hedef_adres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hedef_adres.Location = new System.Drawing.Point(102, 397);
            this.lbl_hedef_adres.Name = "lbl_hedef_adres";
            this.lbl_hedef_adres.Size = new System.Drawing.Size(0, 19);
            this.lbl_hedef_adres.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(368, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 33);
            this.button3.TabIndex = 43;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UC_Ayarlar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_hedef_adres);
            this.Controls.Add(this.btn_fatura_hedef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_fatura_kaynak_degistir);
            this.Controls.Add(this.lbl_fatura_kaynak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnl_degistir_ekrani);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.lbl_birim_fiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UC_Ayarlar";
            this.Size = new System.Drawing.Size(1051, 580);
            this.Load += new System.EventHandler(this.UC_Ayarlar_Load);
            this.pnl_degistir_ekrani.ResumeLayout(false);
            this.pnl_degistir_ekrani.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_birim_fiyat;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Panel pnl_degistir_ekrani;
        private System.Windows.Forms.TextBox txt_birim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_birim_kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_fatura_kaynak;
        private System.Windows.Forms.Button btn_fatura_kaynak_degistir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_fatura_hedef;
        private System.Windows.Forms.Label lbl_hedef_adres;
        private System.Windows.Forms.Button button3;
    }
}
