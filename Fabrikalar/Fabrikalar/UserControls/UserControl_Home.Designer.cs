namespace Fabrikalar.UserControls
{
    partial class UserControl_Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma_Adet = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btn_unutulmus_siparis = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_musteri_ekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(158, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugün ki Siparişler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(357, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Firma:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(162, 143);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(473, 308);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.Format = "E3";
            dataGridViewCellStyle1.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Adet";
            this.Column2.Name = "Column2";
            // 
            // Firma_Adet
            // 
            this.Firma_Adet.AutoSize = true;
            this.Firma_Adet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Firma_Adet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Firma_Adet.Location = new System.Drawing.Point(420, 53);
            this.Firma_Adet.Name = "Firma_Adet";
            this.Firma_Adet.Size = new System.Drawing.Size(0, 19);
            this.Firma_Adet.TabIndex = 18;
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSiparis.FlatAppearance.BorderSize = 0;
            this.btnSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.ForeColor = System.Drawing.Color.White;
            this.btnSiparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparis.Location = new System.Drawing.Point(454, 472);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(181, 60);
            this.btnSiparis.TabIndex = 19;
            this.btnSiparis.Text = "Siparişleri Kaydet";
            this.btnSiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btn_unutulmus_siparis
            // 
            this.btn_unutulmus_siparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_unutulmus_siparis.FlatAppearance.BorderSize = 0;
            this.btn_unutulmus_siparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unutulmus_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_unutulmus_siparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_unutulmus_siparis.Location = new System.Drawing.Point(850, 53);
            this.btn_unutulmus_siparis.Name = "btn_unutulmus_siparis";
            this.btn_unutulmus_siparis.Size = new System.Drawing.Size(181, 60);
            this.btn_unutulmus_siparis.TabIndex = 20;
            this.btn_unutulmus_siparis.Text = "Unutulmuş Sipariş Ekle";
            this.btn_unutulmus_siparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_unutulmus_siparis.UseVisualStyleBackColor = false;
            this.btn_unutulmus_siparis.Click += new System.EventHandler(this.btn_unutulmus_siparis_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 76);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_tarih.Location = new System.Drawing.Point(25, 33);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(46, 21);
            this.lbl_tarih.TabIndex = 22;
            this.lbl_tarih.Text = "tarih";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.lbl_tarih);
            this.groupBox1.Location = new System.Drawing.Point(713, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 291);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unutulmuş Sipariş";
            this.groupBox1.Visible = false;
            // 
            // btn_musteri_ekle
            // 
            this.btn_musteri_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_musteri_ekle.FlatAppearance.BorderSize = 0;
            this.btn_musteri_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musteri_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_musteri_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_musteri_ekle.Location = new System.Drawing.Point(514, 53);
            this.btn_musteri_ekle.Name = "btn_musteri_ekle";
            this.btn_musteri_ekle.Size = new System.Drawing.Size(121, 33);
            this.btn_musteri_ekle.TabIndex = 24;
            this.btn_musteri_ekle.Text = "Müşteri Ekle";
            this.btn_musteri_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_musteri_ekle.UseVisualStyleBackColor = false;
            this.btn_musteri_ekle.Click += new System.EventHandler(this.btn_musteri_ekle_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(474, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 33);
            this.button3.TabIndex = 29;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserControl_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_musteri_ekle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_unutulmus_siparis);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.Firma_Adet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserControl_Home";
            this.Size = new System.Drawing.Size(1081, 580);
            this.Load += new System.EventHandler(this.UserControl_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label Firma_Adet;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btn_unutulmus_siparis;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_musteri_ekle;
        private System.Windows.Forms.Button button3;
    }
}
