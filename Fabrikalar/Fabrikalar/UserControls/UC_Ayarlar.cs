using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrikalar.Kodlar;
using Fabrikalar.Forms;
using System.Data.SqlClient;

namespace Fabrikalar.UserControls
{
    public partial class UC_Ayarlar : UserControl
    {
        public UC_Ayarlar()
        {
            InitializeComponent();
        }
        private static bool varmi = false;
        private void UC_Ayarlar_Load(object sender, EventArgs e)
        {
            labele_yaz();
        }

        private void labele_yaz()
        {
            string birim;
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select birim from Birim_Ucret", bgl.baglanti());
            SqlDataReader komut_reader = komut.ExecuteReader();
            while (komut_reader.Read())
            {
                birim = (komut_reader["birim"]).ToString();
                lbl_birim_fiyat.Text = birim + " ₺";
                txt_birim.Text = birim;

            }
            SqlCommand fatura_kaynak = new SqlCommand("Select Kaynak_Excel from Excel_Path", bgl.baglanti());
            SqlDataReader fatura_kaynak_reader = fatura_kaynak.ExecuteReader();
            while (fatura_kaynak_reader.Read())
            {
                lbl_fatura_kaynak.Text = fatura_kaynak_reader["Kaynak_Excel"].ToString();
            }

            SqlCommand fatura_hedef = new SqlCommand("Select Hedef_Excel from Excel_Path", bgl.baglanti());
            SqlDataReader fatura_hedef_reader = fatura_hedef.ExecuteReader();
            while (fatura_hedef_reader.Read())
            {
                lbl_hedef_adres.Text = fatura_hedef_reader["Hedef_Excel"].ToString();
            }

            bgl.kapat();

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            pnl_degistir_ekrani.Visible = false;
            btn_degistir.Visible = true;
            btn_fatura_hedef.Visible = true;
            btn_fatura_kaynak_degistir.Visible = true;
            button3.Visible = true;
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            pnl_degistir_ekrani.Visible = true;
            btn_degistir.Visible = false;
            btn_fatura_hedef.Visible = false;
            btn_fatura_kaynak_degistir.Visible = false;
            button3.Visible = false;
        }

        private string birim_fiyat_duzeltme()
        {
          
            string birim = txt_birim.Text;
            string degisti = birim.Replace(".", ",");
            return degisti;
        
            
        }

        private void btn_birim_kaydet_Click(object sender, EventArgs e)
        {

            string yeni_birim_fiyat= birim_fiyat_duzeltme();
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand kontrol = new SqlCommand("Select birim from Birim_Ucret",bgl.baglanti());
            SqlDataReader kontrol_reader = kontrol.ExecuteReader();
            while(kontrol_reader.Read())
            {
                MessageBox.Show(kontrol_reader["birim"].ToString());
                if (kontrol_reader.HasRows == true)
                    varmi = true;
            }
            if(varmi==true)
            {
                SqlCommand komut = new SqlCommand("Update Birim_Ucret Set birim='" + yeni_birim_fiyat + "'", bgl.baglanti());
                SqlDataReader komut_reader = komut.ExecuteReader();
                lbl_birim_fiyat.Text = yeni_birim_fiyat + " ₺";
                MessageBox.Show("Kaydedildi !!");
                pnl_degistir_ekrani.Visible = false;
                btn_degistir.Visible = true;
            }
            else
            {
                SqlCommand ekle = new SqlCommand("insert into Birim_Ucret(birim) values('" + yeni_birim_fiyat+ "')", bgl.baglanti());
                SqlDataReader ekle_reader = ekle.ExecuteReader();
            }
            bgl.kapat();

        }

        private void btn_fatura_kaynak_degistir_Click(object sender, EventArgs e)
        {
            Excel_Kaynak kaynak = new Excel_Kaynak();
            kaynak.Show();
            
        }

        private void btn_fatura_hedef_Click(object sender, EventArgs e)
        {
            pnl_Excel_Hedef hedef = new pnl_Excel_Hedef();
            hedef.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand fatura_kaynak = new SqlCommand("Select Kaynak_Excel from Excel_Path", bgl.baglanti());
            SqlDataReader fatura_kaynak_reader = fatura_kaynak.ExecuteReader();
            while (fatura_kaynak_reader.Read())
            {
                lbl_fatura_kaynak.Text = fatura_kaynak_reader["Kaynak_Excel"].ToString();
            }

            SqlCommand fatura_hedef = new SqlCommand("Select Hedef_Excel from Excel_Path", bgl.baglanti());
            SqlDataReader fatura_hedef_reader = fatura_hedef.ExecuteReader();
            while (fatura_hedef_reader.Read())
            {
                lbl_hedef_adres.Text = fatura_hedef_reader["Hedef_Excel"].ToString();
            }

            bgl.kapat();
        }
    }
}
