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
    public partial class Musteri_Ekle : Form
    {
        public Musteri_Ekle()
        {
            InitializeComponent();
        }

        private static string txt_tel = "";
        private static int tel_sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tel_donustur(string firma_tel)
        {
            tel_sayac = 0;
            string tel = "";

            for (int i = 0; i < firma_tel.Length; i++)
            {
                if (i == 0 || i == 4)
                { }
                else
                {
                    if (i == 9)
                    {
                        tel += " ";
                    }
                    else
                    {
                        if (firma_tel[i] != ' ')
                        {
                            tel_sayac++;
                            txt_tel += firma_tel[i];
                        }

                        tel += firma_tel[i];
                    }

                }
            }
            return tel;
        }
        private void btnYemek_Ekle_Click(object sender, EventArgs e)
        {
            string adi = txt_firma_adi.Text;
            string tel = txt_firma_telefon.Text;
            //MessageBox.Show(tel);
            string adres = txt_firma_adres.Text;
            if(txt_firma_adi.Text.Trim() != String.Empty)
            {
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand kontrol = new SqlCommand("Select * from Sirket_Bilgi where Sirket_adi='"+adi+"'", bgl.baglanti());
                SqlDataReader kontrol_reader = kontrol.ExecuteReader();
                
                    if(kontrol_reader.HasRows == true)
                    {
                        MessageBox.Show(adi + " zaten kayıtlı");
                    }
                    else
                    {
                    tel = tel_donustur(tel);
                    if(tel.Trim() != "" && tel_sayac < 10)
                    {
                        MessageBox.Show("Telefon Numarasını Eksik Girdiniz");
                    }
                    else
                    {
                        SqlCommand komut = new SqlCommand("insert into Sirket_Bilgi(Sirket_adi,Sirket_tel,Sirket_adres) values('" + adi + "','" + tel + "','" + adres + "')", bgl.baglanti());
                        SqlDataReader komut_reader = komut.ExecuteReader();
                        while (komut_reader.Read())
                        { }
                        this.Close();
                        MessageBox.Show("Başarıyla Kaydedildi!!");
                    }
                }
                    
                
                bgl.kapat();
            }
            else
            {
                MessageBox.Show("Firma adı girmeyi Unuttunuz!!");
            }
           

        }
    }
}
