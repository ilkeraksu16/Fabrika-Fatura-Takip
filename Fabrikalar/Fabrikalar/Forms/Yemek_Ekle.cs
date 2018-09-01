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

namespace Fabrikalar.Forms
{
    public partial class Yemek_Ekle : Form
    {
        public Yemek_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int Yemek_turu()
        {
            string yemek_ismi = cbbx_yemek_turu.Text;
            if(yemek_ismi == "Yemek")
            {
                return 1;
            }
            else if(yemek_ismi == "Tatlı")
            {
                return 2;
            }
            else if(yemek_ismi == "İçecek")
            {
                return 3;
            }
            else
            {
                return 0;
            }
            
        }
        private void Yemek_add(int yemek_turu)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            string yemek_adi = txtyemek.Text;
            SqlCommand kontrol_yemek = new SqlCommand("select * from Yemekler where yemek_adi='" + yemek_adi + "'", bgl.baglanti());
            SqlDataReader kontrol_reader = kontrol_yemek.ExecuteReader();
            if (kontrol_reader.HasRows == true)
            {
                MessageBox.Show(yemek_adi + " zaten kayıtlı!!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Yemekler(yemek_adi,tip) values('" + yemek_adi + "','" + yemek_turu + "')", bgl.baglanti());
                SqlDataReader komut_reader = komut.ExecuteReader();
                this.Close();
                MessageBox.Show("Başarıyla Kaydedildi!!");


            }
            bgl.kapat();
        }
        private void btnYemek_Ekle_Click(object sender, EventArgs e)
        {
            if(txtyemek.Text.Trim() != String.Empty)
            { 
                int yemek_turu = Yemek_turu();
                if(yemek_turu != 0)
                {
                    Yemek_add(yemek_turu);
                    
                }
                else
                {
                    MessageBox.Show("Yemek Türünü Seçiniz!!");
                }
            }
            else
            {
                MessageBox.Show("Yemek İsmi Giriniz!!");
            }

        }

        private void Yemek_Ekle_Load(object sender, EventArgs e)
        {
            cbbx_yemek_turu.SelectedText = "Türü Seçiniz!";
        }
    }
}
