namespace Fabrikalar.Forms
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.zaman = new System.Windows.Forms.Label();
            this.btnMenuOlustur = new System.Windows.Forms.Button();
            this.Tarih = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.panelcubuk = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.yemek1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelKontrol = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.zaman);
            this.panelLeft.Controls.Add(this.btnMenuOlustur);
            this.panelLeft.Controls.Add(this.Tarih);
            this.panelLeft.Controls.Add(this.btnAyarlar);
            this.panelLeft.Controls.Add(this.btnMusteriEkle);
            this.panelLeft.Controls.Add(this.btnSiparis);
            this.panelLeft.Controls.Add(this.panelcubuk);
            this.panelLeft.Controls.Add(this.btnAnasayfa);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 767);
            this.panelLeft.TabIndex = 0;
            // 
            // zaman
            // 
            this.zaman.AutoSize = true;
            this.zaman.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.ForeColor = System.Drawing.Color.White;
            this.zaman.Location = new System.Drawing.Point(31, 590);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(112, 25);
            this.zaman.TabIndex = 10;
            this.zaman.Text = "HH:MM:SS";
            // 
            // btnMenuOlustur
            // 
            this.btnMenuOlustur.FlatAppearance.BorderSize = 0;
            this.btnMenuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOlustur.ForeColor = System.Drawing.Color.White;
            this.btnMenuOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuOlustur.Image")));
            this.btnMenuOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOlustur.Location = new System.Drawing.Point(9, 272);
            this.btnMenuOlustur.Name = "btnMenuOlustur";
            this.btnMenuOlustur.Size = new System.Drawing.Size(203, 60);
            this.btnMenuOlustur.TabIndex = 9;
            this.btnMenuOlustur.Text = "   Aylık Menü Oluştur";
            this.btnMenuOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuOlustur.UseVisualStyleBackColor = true;
            this.btnMenuOlustur.Click += new System.EventHandler(this.btnMenuOlustur_Click);
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.ForeColor = System.Drawing.Color.White;
            this.Tarih.Location = new System.Drawing.Point(8, 533);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(83, 19);
            this.Tarih.TabIndex = 8;
            this.Tarih.Text = "HH:MM:SS";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(12, 404);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(203, 60);
            this.btnAyarlar.TabIndex = 6;
            this.btnAyarlar.Text = "   Ayarlar";
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.Location = new System.Drawing.Point(11, 338);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(203, 60);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "   Müşteri Bilgileri";
            this.btnMusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.FlatAppearance.BorderSize = 0;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.ForeColor = System.Drawing.Color.White;
            this.btnSiparis.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparis.Image")));
            this.btnSiparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparis.Location = new System.Drawing.Point(11, 206);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(203, 60);
            this.btnSiparis.TabIndex = 4;
            this.btnSiparis.Text = "   Firmaların Eski Siparişleri";
            this.btnSiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // panelcubuk
            // 
            this.panelcubuk.BackColor = System.Drawing.Color.White;
            this.panelcubuk.Location = new System.Drawing.Point(1, 142);
            this.panelcubuk.Name = "panelcubuk";
            this.panelcubuk.Size = new System.Drawing.Size(7, 60);
            this.panelcubuk.TabIndex = 3;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(11, 140);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(203, 60);
            this.btnAnasayfa.TabIndex = 3;
            this.btnAnasayfa.Text = "   Günlük Sipariş Ekle";
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 140);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(176, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 26);
            this.button6.TabIndex = 8;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yönetim Sistemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Safran Lokantası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_minimize);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 48);
            this.panel3.TabIndex = 1;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.White;
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.Location = new System.Drawing.Point(1061, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(41, 48);
            this.btn_minimize.TabIndex = 10;
            this.btn_minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1102, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 48);
            this.button7.TabIndex = 9;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Safran Lokantası Yönetim Sistemi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.yemek1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1145, 92);
            this.panel4.TabIndex = 2;
            // 
            // yemek1
            // 
            this.yemek1.AutoSize = true;
            this.yemek1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yemek1.ForeColor = System.Drawing.Color.White;
            this.yemek1.Location = new System.Drawing.Point(304, 31);
            this.yemek1.Name = "yemek1";
            this.yemek1.Size = new System.Drawing.Size(229, 25);
            this.yemek1.TabIndex = 5;
            this.yemek1.Text = "Bugünlük Sipariş Yok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bugün ki Menü: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelKontrol
            // 
            this.panelKontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKontrol.Location = new System.Drawing.Point(215, 140);
            this.panelKontrol.Name = "panelKontrol";
            this.panelKontrol.Size = new System.Drawing.Size(1145, 627);
            this.panelKontrol.TabIndex = 3;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 767);
            this.Controls.Add(this.panelKontrol);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Panel panelcubuk;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelKontrol;
        private System.Windows.Forms.Label yemek1;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.Button btnMenuOlustur;
        private System.Windows.Forms.Label zaman;
        private System.Windows.Forms.Button btn_minimize;
    }
}