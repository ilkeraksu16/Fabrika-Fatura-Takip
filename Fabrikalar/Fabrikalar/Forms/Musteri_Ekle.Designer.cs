namespace Fabrikalar.Forms
{
    partial class Musteri_Ekle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_firma_adi = new System.Windows.Forms.TextBox();
            this.txt_firma_telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_firma_adres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYemek_Ekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Ekle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnYemek_Ekle);
            this.panel2.Controls.Add(this.txt_firma_adres);
            this.panel2.Controls.Add(this.txt_firma_telefon);
            this.panel2.Controls.Add(this.txt_firma_adi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(2, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 372);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres";
            // 
            // txt_firma_adi
            // 
            this.txt_firma_adi.Location = new System.Drawing.Point(199, 23);
            this.txt_firma_adi.Name = "txt_firma_adi";
            this.txt_firma_adi.Size = new System.Drawing.Size(224, 27);
            this.txt_firma_adi.TabIndex = 3;
            // 
            // txt_firma_telefon
            // 
            this.txt_firma_telefon.Location = new System.Drawing.Point(199, 87);
            this.txt_firma_telefon.Mask = "(999) 000-0000";
            this.txt_firma_telefon.Name = "txt_firma_telefon";
            this.txt_firma_telefon.Size = new System.Drawing.Size(123, 27);
            this.txt_firma_telefon.TabIndex = 4;
            // 
            // txt_firma_adres
            // 
            this.txt_firma_adres.Location = new System.Drawing.Point(199, 159);
            this.txt_firma_adres.Multiline = true;
            this.txt_firma_adres.Name = "txt_firma_adres";
            this.txt_firma_adres.Size = new System.Drawing.Size(224, 105);
            this.txt_firma_adres.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(49, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 24;
            this.button1.Text = "İptal";
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
            this.btnYemek_Ekle.Location = new System.Drawing.Point(293, 287);
            this.btnYemek_Ekle.Name = "btnYemek_Ekle";
            this.btnYemek_Ekle.Size = new System.Drawing.Size(130, 55);
            this.btnYemek_Ekle.TabIndex = 23;
            this.btnYemek_Ekle.Text = "Kaydet";
            this.btnYemek_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYemek_Ekle.UseVisualStyleBackColor = false;
            this.btnYemek_Ekle.Click += new System.EventHandler(this.btnYemek_Ekle_Click);
            // 
            // Musteri_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(521, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musteri_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri_Ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firma_adres;
        private System.Windows.Forms.MaskedTextBox txt_firma_telefon;
        private System.Windows.Forms.TextBox txt_firma_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYemek_Ekle;
    }
}