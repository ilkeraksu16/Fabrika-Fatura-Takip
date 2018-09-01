using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrikalar.Kodlar;
using System.Data.SqlClient;
namespace Fabrikalar.Forms
{
    public partial class Excel_Kaynak : Form
    {
        public Excel_Kaynak()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*fatura_kaynağını seçme işlemi*/
        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = "", dosya_adi = "",label="";
            label = lbl_adres.Text;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";
            file.RestoreDirectory = true;
            file.Title = "Excel Dosyası Seçiniz..";
            
            
            if (file.ShowDialog() == DialogResult.OK)
            {
                dosya_yolu = file.FileName;
                dosya_adi = file.SafeFileName;
                string varmi = "";
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand kontrol = new SqlCommand("Select ilk_mi from Excel_Path", bgl.baglanti());
                SqlDataReader kontrol_reader = kontrol.ExecuteReader();
                while(kontrol_reader.Read())
                {
                    varmi = kontrol_reader["ilk_mi"].ToString();
                    
                }
                if (varmi != "")
                {
                    SqlCommand komut = new SqlCommand("Update Excel_Path Set Kaynak_Excel='" + dosya_yolu + "'", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    this.Close();
                    MessageBox.Show("Kaydedildi!!");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into Excel_Path(Kaynak_Excel,ilk_mi) Values('" + dosya_yolu + "','1')", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    this.Close();
                    MessageBox.Show("Kaydedildi!!");
                }
                bgl.kapat();
                
            }

        }

        private void Excel_Kaynak_Load(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select Kaynak_Excel from Excel_Path",bgl.baglanti());
            SqlDataReader komut_reader = komut.ExecuteReader();
            while(komut_reader.Read())
            {
                lbl_adres.Text = komut_reader["Kaynak_Excel"].ToString();
            }
            bgl.kapat();

        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
