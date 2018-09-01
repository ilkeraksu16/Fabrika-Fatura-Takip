using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Fabrikalar.Kodlar;
using Fabrikalar.Forms;
using System.Diagnostics;

namespace Fabrikalar.UserControls
{
    public partial class UC_Eski_Siparisler : UserControl
    {
       

        public UC_Eski_Siparisler()
        {
            InitializeComponent();
        }

        private static string ay,yil,firma_adi, turkce_ay,birim_fiyat,excel_hedef="",excel_kaynak="";
        private static int firma_id,adet,index2;
        private static double toplam_ucret;
        
       
        
        private void UC_Eski_Siparisler_Load(object sender, EventArgs e)
        {
            datagrid_yaz();
            ay = DateTime.Now.Month.ToString();
            if (Convert.ToInt32(ay) < 10)
                ay = "0" + ay;
            yil = DateTime.Now.Year.ToString();
            turkce_ay = DateTime.Now.ToString("MMMM");
            Baslik_yaz();
            if(dataGridView1.RowCount>0)
            {
                datagrid_Siparis_Doldur(0);
                
            }
            adet = adet_bul();
            birim_fiyat = birim_ucret();
            toplam_ucret = total_ucret();
        }

        private void Baslik_yaz()
        {
            firma.Text = firma_adi + " Firmasının " + turkce_ay + " siparişi";
        }
        
        private void datagrid_yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select Sirket_adi  From Sirket_Bilgi", bgl.baglanti());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlDa.Dispose();
            bgl.kapat();
            dataGridView1.Columns[0].HeaderText = "Firma";
            if(dataGridView1.RowCount > 0)
                firma_adi = dataGridView1.Rows[0].Cells[0].Value.ToString();
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgl.kapat();
        }

        private int adet_bul()
        {
            int satir_sayisi = dataGridView2.RowCount;
            int miktar=0;
            for(int i=0;i<satir_sayisi;i++)
            {
                miktar = miktar + Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
            }
            toplam_adet.Text = miktar.ToString();
            return miktar;
        }

        /*datagrid2 sipariş yaz*/
        private void dataGrid_siparis_yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            SqlDataAdapter sqlDa = new SqlDataAdapter("Select tarih, adet From Yemek_adet_bilgi where (Sirket_id='" + firma_id + "') AND (DATEPART(year,tarih)=" + yil + ") AND (DATEPART(month,tarih)=" + ay + ") Order By tarih ASC", bgl.baglanti());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            sqlDa.Dispose();
            bgl.kapat();
          
        }

        private void dataGrid3_siparis_yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            SqlDataAdapter sqlDa = new SqlDataAdapter("Select tarih,adet From Yemek_adet_bilgi where (Sirket_id='" + firma_id + "') AND (DATEPART(year,tarih)=" + yil + ") AND (DATEPART(month,tarih)=" + ay + ") Order By tarih ASC", bgl.baglanti());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
            dataGridView3.Columns[0].HeaderText = "Tarih";
            dataGridView3.Columns[1].HeaderText = "Adet";
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            duzenleme_baslik.Text = turkce_ay + " Ayının Düzenleme Ekranı";
            sqlDa.Dispose();
            bgl.kapat();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            turkce_ay = e.Start.ToString("MMMM");
            ay = e.Start.Month.ToString();
            yil = e.Start.Year.ToString();
            Baslik_yaz();
            dataGrid_siparis_yaz();
            adet = adet_bul();
            toplam_ucret = total_ucret();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
        }
    
        /*Sipariş Sil*/
        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView2.RowCount>0)
            {
                if (index2 >= 0)
                {
                    string date = dataGridView2.Rows[index2].Cells[0].Value.ToString();
                    string miktar = dataGridView2.Rows[index2].Cells[1].Value.ToString();
                    string[] zmn = date.Split(' ');
                    
                    DialogResult sonuc = MessageBox.Show(firma_adi + " Firmasının\n" + zmn[0] + " Tarihli \n" + miktar + " Adetli\n Siparişi Silinsin Mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.No)
                    {

                    }
                    else
                    {
                        string vakit = get_zaman(zmn[0]);
                        SqlBaglantisi bgl = new SqlBaglantisi();
                        SqlCommand komut = new SqlCommand("DELETE From Yemek_adet_bilgi where tarih='" + vakit + "'AND sirket_id='"+firma_id+"'", bgl.baglanti());
                        SqlDataReader komut_reader = komut.ExecuteReader();
                        bgl.kapat();
                        dataGrid_siparis_yaz();
                        adet = adet_bul();
                        toplam_ucret = total_ucret();
                        MessageBox.Show("Başarıyla Silindi!!");
                    }
                }
                else
                {
                    MessageBox.Show("Silmek İstediğiniz Siparişi Seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Sipariş Listesi Boş!!");
            }
         
        }
        /*sipariş düzenle*/
        private void btnYemek_Ekle_Click(object sender, EventArgs e)
        {
            int miktar = dataGridView2.RowCount;
            if(miktar > 0)
            {
                btnYemek_Ekle.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                duzenle.Visible = true;
                dataGrid3_siparis_yaz();
            }
            else
            {
                MessageBox.Show("Sipariş Listesi Zaten Boş!!");
            }

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            duzenle.Visible = false;
            btnYemek_Ekle.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int sayac = dataGridView3.RowCount;
            string zaman,temp;
            string[] gecici;
            int adet;
            if(sayac > 0)
            {
               
                    SqlBaglantisi bgl = new SqlBaglantisi();

                    for (int i = 0; i < sayac; i++)
                    {
                        temp = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        gecici = temp.Split(' ');
                        zaman = get_zaman(gecici[0]);
                    adet = Convert.ToInt32 (dataGridView3.Rows[i].Cells[1].Value);
                    
                        SqlCommand guncelle = new SqlCommand("Update Yemek_adet_bilgi Set adet ='" + adet + "' where tarih='" + zaman + "' AND Sirket_id='" + firma_id + "'", bgl.baglanti());
                        SqlDataReader guncelle_reader = guncelle.ExecuteReader();

                    }
                    bgl.kapat();
                    duzenle.Visible = false;
                    btnYemek_Ekle.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    dataGrid_siparis_yaz();
                    adet = adet_bul();
                    toplam_ucret = total_ucret();
                    MessageBox.Show("Siparişler Düzenlendi!!");
                
            }
            else
            {
                MessageBox.Show("Siparişler Listesi Boş!!");
            }
        }
        //çıktı al
        private void button2_Click(object sender, EventArgs e)
        {
            int satir = dataGridView2.RowCount;
            string zaman = "", miktar = "",bas="",klasor_ad="";
            string[] temp;
            int sutun = 2;
            if(satir > 0)
            {
                Fatura_Hedef_Kaynak();
                if(excel_hedef =="")
                {
                    pnl_Excel_Hedef hedef = new pnl_Excel_Hedef();
                    hedef.Show();
                }
                if(excel_kaynak =="")
                {
                    Excel_Kaynak kaynak = new Excel_Kaynak();
                    kaynak.Show();
                }
                klasor_ad = yil.ToString() + "-" + turkce_ay;
                //string path_belgeler = @"C:\\Users\\İlker\\Documents\\"; 
                
                Klasor_Olustur_Sil klasor = new Klasor_Olustur_Sil();
                if(!(klasor.klasor_varmi(excel_hedef,klasor_ad)))
                {
                    klasor.klasor_olustur(klasor_ad, excel_hedef + "\\");
                }
                
                    

                Excel excel = new Excel(excel_kaynak, 1);
                bas = DateTime.Now.ToLongDateString();
                excel.Hucreye_yaz(5, 2, firma_adi.ToUpper()+ " FATURA DÖKÜMÜ");
                excel.Hucreye_yaz(9, 6, adet.ToString());
                excel.Hucreye_yaz(10, 6, birim_fiyat.ToString()+ " ₺");
                excel.Hucreye_yaz(11, 6, toplam_ucret.ToString()+ " ₺");
                excel.Hucreye_yaz(1, 6,bas);
                
                for(int i =0;i<satir;i++)
                {
                    zaman = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    temp = zaman.Split(' ');
                    excel.Hucreye_yaz(10 + i, sutun, temp[0]);
                    sutun++;
                    miktar = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    excel.Hucreye_yaz(10 + i, sutun, miktar);
                    sutun = 2;
                }
                //excel.Save();

                if (excel.excel_varmi(excel_hedef+"\\"+klasor_ad, firma_adi + ".xlsx"))
                {
                    excel.excel_sil(excel_hedef + "\\" + klasor_ad, firma_adi + ".xlsx");
                    excel.SaveAs(@excel_hedef + "\\" + klasor_ad + "\\" + firma_adi + ".xlsx");
                }
                else
                    excel.SaveAs(@excel_hedef + "\\" + klasor_ad + "\\" + firma_adi + ".xlsx");

                excel.Close();
                //MessageBox.Show(excel_hedef + "\\" + klasor_ad + "\n Adresine Fatura Oluşturuldu.");

                DialogResult result1 = MessageBox.Show("Fatura Başarıyla Oluşturuldu.\nFatura Gösterilsin Mi?",
                "Fatura",
                MessageBoxButtons.YesNo);
                if(result1 == DialogResult.Yes)
                {
                    Process.Start(@excel_hedef + "\\" + klasor_ad);
                }
            }
            else
            {
                MessageBox.Show("Siparişler Listesi Boş Çıktı Alınamaz!!");
            }
        }

        public string get_zaman(string date)
        {

            if (date != null)
            {
                string zaman, gun, ay, yil;
                string[] dizi = date.Split('.');

                //int sayac = 0;
                gun = dizi[0];
                ay = dizi[1];
                yil = dizi[2];
                if (Convert.ToInt32(gun) < 10)
                    gun = "0" + gun;
                zaman = yil + "-" + ay + "-" + gun;
                return zaman;

            }

            return "";
        }

        private void datagrid_Siparis_Doldur(int index)
        {
            
            firma_adi = dataGridView1.Rows[index].Cells[0].Value.ToString();
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select Sirket_id From Sirket_Bilgi where Sirket_adi = '" + firma_adi + "'", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                firma_id = Convert.ToInt32(oku["Sirket_id"]);

            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select tarih, adet From Yemek_adet_bilgi where (Sirket_id='" + firma_id + "') AND (DATEPART(year,tarih)=" + yil + ") AND (DATEPART(month,tarih)=" + ay + ") Order By tarih ASC", bgl.baglanti());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            sqlDa.Dispose();
            dataGridView2.Columns[0].HeaderText = "Tarih";
            dataGridView2.Columns[0].MinimumWidth = 120;
            dataGridView2.Columns[1].HeaderText = "Adet";
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgl.kapat();
        }
        private double total_ucret()
        {
            double total;
            int adet = Convert.ToInt32(toplam_adet.Text);
            total = adet * Convert.ToDouble( birim_fiyat);
            tutar.Text = total.ToString() + " ₺";
            return total;
        }
        private string birim_ucret()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            string ucret="";
            SqlCommand komut = new SqlCommand("Select birim From Birim_Ucret", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ucret = oku["birim"].ToString();

            }
            brm_ucret.Text = ucret.ToString() + " ₺";
            bgl.kapat();
            return ucret;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index= e.RowIndex;
            if(index>=0)
            {
                firma_adi = dataGridView1.Rows[index].Cells[0].Value.ToString();
                Baslik_yaz();
                datagrid_Siparis_Doldur(index);
                adet = adet_bul();
                toplam_ucret = total_ucret();
            }
            
        }

        private void Fatura_Hedef_Kaynak()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select * from Excel_Path",bgl.baglanti());
            SqlDataReader komut_reader = komut.ExecuteReader();
            while(komut_reader.Read())
            {
                excel_hedef = komut_reader["Hedef_Excel"].ToString();
                excel_kaynak = komut_reader["Kaynak_Excel"].ToString();
            }
            bgl.kapat();
        }

        private void btn_musteri_ekle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            SqlCommand id_bul = new SqlCommand("", bgl.baglanti());
        }
    }
}
