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
using Fabrikalar.Forms;

namespace Fabrikalar.UserControls
{
    public partial class UserControl_Home : UserControl
    {
        public UserControl_Home()
        {
            InitializeComponent();
        }

        public static Boolean unutulmus_siparis_visible=false;
        private static string date=""; 
        private void UserControl_Home_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            
        }
        private void datagrid_doldur()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select Sirket_adi  From Sirket_Bilgi", bgl.baglanti());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlDa.Dispose();
            bgl.kapat();
            dataGridView1.Columns[1].HeaderText = "Firma";
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Firma_Adet.Text = (dataGridView1.Rows.Count).ToString();
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /*Adet Kısmına yalnızca rakam girmek için*/
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            /*renk değişimi*/
            dataGridView1.CurrentCell.Style.BackColor = Color.Purple;
            dataGridView1.CurrentCell.Style.ForeColor = Color.White;
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        /*Adet Kısmına yalnızca rakam girmek için*/
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            
                int firma = (dataGridView1.Rows.Count);

                SqlBaglantisi bgl = new SqlBaglantisi();

                int adet, firma_id,guncellendi_mi=0;
                string firma_adi, tarih;
                tarih = get_zaman();

                for (int i = 0; i < firma; i++)
                {

                    firma_adi = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    adet = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    //MessageBox.Show(adet.ToString());
                    SqlCommand komut = new SqlCommand("Select Sirket_id From Sirket_Bilgi where Sirket_adi = '" + firma_adi + "'", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    firma_id = Convert.ToInt32(oku["Sirket_id"]);
                    if (date == "")
                    {
                        if(adet!= 0)
                        {
                            if(siparis_varmi(tarih,firma_id) == false)
                            {
                                SqlCommand komut_ekle = new SqlCommand("insert into Yemek_adet_bilgi(Sirket_id, adet, tarih) values('" + firma_id + "', '" + adet + "', '" + tarih + "' )", bgl.baglanti());
                                SqlDataReader ekle_reader = komut_ekle.ExecuteReader();
                            }
                            else
                            {
                                SqlCommand guncelle = new SqlCommand("Update Yemek_adet_bilgi Set adet ='" + adet + "' where tarih='" + tarih + "' AND Sirket_id='" + firma_id + "'", bgl.baglanti());
                                SqlDataReader guncelle_reader = guncelle.ExecuteReader();
                                guncellendi_mi = 1;

                            }

                        }
                        
                    }
                    else
                    {
                        if(adet !=0)
                        {
                            
                            string zaman = zaman_parcala(date);
                            if (siparis_varmi(zaman,firma_id) == false)
                            {
                                SqlCommand komut_ekle = new SqlCommand("insert into Yemek_adet_bilgi(Sirket_id, adet, tarih) values('" + firma_id + "', '" + adet + "', '" + zaman + "' )", bgl.baglanti());
                                SqlDataReader ekle_reader = komut_ekle.ExecuteReader();
                            }
                            else
                            {
                                SqlCommand guncelle = new SqlCommand("Update Yemek_adet_bilgi Set adet ='" + adet + "' where tarih='" + zaman + "' AND Sirket_id='" + firma_id + "'", bgl.baglanti());
                                SqlDataReader guncelle_reader = guncelle.ExecuteReader();
                                guncellendi_mi = 1;

                            }

                        }
                        
                        

                    }


                }
                }
            bgl.kapat();
            date = "";
            if (guncellendi_mi == 1)
                MessageBox.Show("Aynı Tarihe Sipariş Alınmıştı.\n Sipariş Bilgilerini Güncellediniz!!");
            else
                MessageBox.Show("Siparişler Başarıyla Kaydedildi!!");
            guncellendi_mi = 0;
           
        }

        private bool siparis_varmi(string tarih , int firma_no)
        {
            bool temp=false;
            SqlBaglantisi baglanti = new SqlBaglantisi();
            SqlCommand kontrol = new SqlCommand("Select * from Yemek_adet_bilgi where Sirket_id ='"+firma_no+"' AND tarih='"+tarih+"'", baglanti.baglanti());
            SqlDataReader kontrol_reader = kontrol.ExecuteReader();
            while(kontrol_reader.Read())
            {
                if (kontrol_reader.HasRows == true)
                    temp = true;
            }
            return temp;
        }
        public string get_zaman()
        {
            string zaman, gun, ay, yil;
            gun = DateTime.Now.Day.ToString();
            ay = DateTime.Now.Month.ToString();
            yil = DateTime.Now.Year.ToString();

            if (DateTime.Now.Day < 10)
                gun = "0" + gun;
            if (DateTime.Now.Month < 10)
                ay = "0" + ay;

            zaman = yil + "-" + ay + "-" + gun;
            return zaman;
        }

        private void btn_unutulmus_siparis_Click(object sender, EventArgs e)
        {
            if(unutulmus_siparis_visible == false)
            {
                groupBox1.Visible = true;
                unutulmus_siparis_visible = true;
                
            }
            else
            {
                date = "";
                groupBox1.Visible = false;
                unutulmus_siparis_visible = false;
            }
            
        }
        public string zaman_parcala(string date)
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
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbl_tarih.Text = e.Start.ToLongDateString();
            date = e.Start.ToShortDateString();
            string zaman = zaman_parcala(date);
        }

        private void btn_musteri_ekle_Click(object sender, EventArgs e)
        {
            Musteri_Ekle yeni_musteri = new Musteri_Ekle();
            yeni_musteri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagrid_doldur();
        }
    }

    
}
