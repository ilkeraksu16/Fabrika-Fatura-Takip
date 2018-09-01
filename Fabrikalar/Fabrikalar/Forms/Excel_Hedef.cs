using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Fabrikalar.Kodlar;
using System.IO;

namespace Fabrikalar.Forms
{
    public partial class pnl_Excel_Hedef : Form
    {
        public pnl_Excel_Hedef()
        {
            InitializeComponent();
        }
        /*fatura adresi kaydetme yeri*/
        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = "", dosya_adi = "", label = "";
            label = lbl_adres.Text;
            FolderBrowserDialog  file= new FolderBrowserDialog();
            //file.Filter = "Excel Dosyası |*.xlsx";
            //file.RestoreDirectory = true;
            //file.Title = "Excel Dosyası Seçiniz..";


            if (file.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(file.SelectedPath))
            {
                string varmi = "";
                dosya_yolu = file.SelectedPath;
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand kontrol = new SqlCommand("Select ilk_mi from Excel_Path", bgl.baglanti());
                SqlDataReader kontrol_reader = kontrol.ExecuteReader();
                while (kontrol_reader.Read())
                {
                    varmi = kontrol_reader["ilk_mi"].ToString();
                }
                if(varmi != "")
                {
                    SqlCommand komut = new SqlCommand("Update Excel_Path Set Hedef_Excel='" + dosya_yolu + "' ", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    this.Close();
                    MessageBox.Show("Kaydedildi!!");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into Excel_Path(Hedef_Excel,ilk_mi) Values('" + dosya_yolu + "','1')", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    this.Close();
                    MessageBox.Show("Kaydedildi!!");
                }
                bgl.kapat();
                
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_Excel_Hedef_Load(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select Hedef_Excel from Excel_Path", bgl.baglanti());
            SqlDataReader komut_reader = komut.ExecuteReader();
            while (komut_reader.Read())
            {
                lbl_adres.Text = komut_reader["Hedef_Excel"].ToString();
            }
            bgl.kapat();
        }
    }
}
