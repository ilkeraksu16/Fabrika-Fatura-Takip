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
using System.Data.SqlClient;

namespace Fabrikalar.UserControls
{
    public partial class UC_Musteri_Ekle : UserControl
    {
        public UC_Musteri_Ekle()
        {
            InitializeComponent();
        }
        private static int sayac = 1,tel_sayac=0,index=-1;
        private static string kontrol_firma = "",txt_tel="";
        private void UC_Musteri_Ekle_Load(object sender, EventArgs e)
        {
            listview_yaz();
        }
        private void listview_yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlCommand komut = new SqlCommand("Select Sirket_adi,Sirket_tel, Sirket_adres from Sirket_Bilgi", bgl.baglanti());
            SqlDataReader komut_reader = komut.ExecuteReader();
           
            while (komut_reader.Read())
            {
                ListViewItem item = new ListViewItem(sayac.ToString());
                item.SubItems.Add(komut_reader["Sirket_adi"].ToString());
                item.SubItems.Add(komut_reader["Sirket_tel"].ToString());
                item.SubItems.Add(komut_reader["Sirket_adres"].ToString());
                listView1.Items.Add(item);
                sayac++;

            }
            bgl.kapat();
            sayac = 1;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tel;
                string a ="";
                ListViewItem item = listView1.SelectedItems[0];
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);           
                tel = item.SubItems[2].Text.Split(' ');
                txt_gncl_firma.Text = item.SubItems[1].Text;
                
                foreach(string temp in tel)
                {
                    
                    a += temp;
                }
                txt_gncl_tel.Text = a;
                txt_gncl_adres.Text = item.SubItems[3].Text;
                kontrol_firma = item.SubItems[1].Text;
                guncelle_goster();
            }
            catch
            {
                MessageBox.Show("Lütfen Firma seçiniz");
            }
            
        }
        private void ekle_gizle()
        {
            pnl_musteri_ekle.Visible = false;
            btn_guncelle.Visible = true;
            btn_sil.Visible = true;
            btn_ekle.Visible = true;
        }
        private void ekle_goster()
        {
            pnl_musteri_ekle.Visible = true;
            btn_guncelle.Visible = false;
            btn_sil.Visible = false;
            btn_ekle.Visible = false;
        }
        /*iptal butonu*/
        private void button1_Click(object sender, EventArgs e)
        {
            txt_firma_adi.Text = "";
            txt_firma_telefon.Text = "";
            txt_firma_adres.Text = "";
            ekle_gizle();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ekle_goster();
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

        private void guncelle_goster()
        {
            pnl_guncelle.Visible = true;
            btn_guncelle.Visible = false;
            btn_sil.Visible = false;
            btn_ekle.Visible = false;

        }

        private void guncelle_gizle()
        {
            pnl_guncelle.Visible = false;
            btn_guncelle.Visible = true;
            btn_sil.Visible = true;
            btn_ekle.Visible = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secilen_sayisi = listView1.CheckedItems.Count;

            if(secilen_sayisi > 0)
            {
                SqlBaglantisi bgl = new SqlBaglantisi();
                string firma = "";
                foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
                {
                    firma = secilikayitbilgisi.SubItems[1].Text;
                    SqlCommand komut = new SqlCommand("DELETE From Sirket_Bilgi  where Sirket_adi='" + firma + "'", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    secilikayitbilgisi.Remove();
                }
                bgl.kapat();
                MessageBox.Show(secilen_sayisi.ToString() + " Adet Müşteri Silindi");
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Müşteriye Tik Koyunuz!!");
            }
            
        }

        private void btnMusteri_Ekle_Click(object sender, EventArgs e)
        {
            string firma = "", telefon = "", adres = "";
            firma = txt_firma_adi.Text;
            telefon = tel_donustur(txt_firma_telefon.Text);
            adres = txt_firma_adres.Text;

            string[] bilgi = { sayac.ToString(), firma, telefon, adres };
            sayac++;
            bool kayit_kontrol = false;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == firma)
                {
                    kayit_kontrol = true;
                    MessageBox.Show("Firma Zaten Kayıtlı!!");
                }
            }
            if (kayit_kontrol == false)
            {
                ListViewItem item = new ListViewItem(bilgi);
                if (firma != "")
                {
                    if (telefon.Trim() != "" && tel_sayac < 10)
                    {
                        MessageBox.Show("Telefon Numarasını Eksik Girdiniz");
                    }
                    else
                    {
                        SqlBaglantisi bgl = new SqlBaglantisi();
                        SqlCommand komut = new SqlCommand("insert into Sirket_Bilgi(Sirket_adi,Sirket_tel,Sirket_adres) values('" + firma + "','" + telefon + "','" + adres + "')", bgl.baglanti());
                        SqlDataReader komut_reader = komut.ExecuteReader();
                        bgl.kapat();
                        listView1.Items.Add(item);
                        ekle_gizle();
                        MessageBox.Show("Başarıyla Kaydedildi!!");
                        txt_firma_adi.Text = "";
                        txt_firma_telefon.Text = "";
                        txt_firma_adres.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Firma Adı Giriniz!!");
                }
            }
        }

        private void btn_gcl_iptal_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Selected = false;
            guncelle_gizle();
        }

        private void btn_gcl_kaydet_Click(object sender, EventArgs e)
        {
            string firma = txt_gncl_firma.Text;
            string telefon = tel_donustur(txt_gncl_tel.Text);
            string adres = txt_gncl_adres.Text;

            string[] bilgi = { sayac.ToString(), firma, telefon, adres };
            sayac++;
            bool kayit_kontrol = false;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == firma && kontrol_firma!= firma)
                {
                    kayit_kontrol = true;
                    MessageBox.Show("Firma Zaten Kayıtlı!!");
                }
            }
            if (kayit_kontrol == false)
            {
                ListViewItem item = new ListViewItem(bilgi);
                if (firma != "")
                {
                    if (telefon.Trim() != "" && tel_sayac< 10)
                    {
                        MessageBox.Show("Telefon Numarasını Eksik Girdiniz");
                    }
                    else
                    {
                        try
                        {
                            SqlBaglantisi bgl = new SqlBaglantisi();
                            try
                            {
                                SqlCommand komut = new SqlCommand("Update Sirket_Bilgi Set Sirket_adi ='" + firma + "', Sirket_tel= '" + telefon + "', Sirket_adres='" + adres + "' where (Sirket_adi='" + kontrol_firma + "')", bgl.baglanti());
                                SqlDataReader komut_reader = komut.ExecuteReader();
                                bgl.kapat();
                            }
                            catch
                            {
                                MessageBox.Show("Günelleştirme yapılamadı");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Veritabanı bağlantısı yapılamadı!!");
                        }
                        listView1.Items.Clear();
                        listview_yaz();
                        guncelle_gizle();
                        MessageBox.Show("Başarıyla Güncellendi!!");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Firma Adı Giriniz!!");
                }
            }
        }
    }
}
