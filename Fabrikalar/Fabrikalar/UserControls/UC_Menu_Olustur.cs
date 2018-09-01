using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrikalar.Forms;
using Fabrikalar.Kodlar;
using System.Data.SqlClient;
namespace Fabrikalar.UserControls
{
    public partial class UC_Menu_Olustur : UserControl
    {
        public UC_Menu_Olustur()
        {
            InitializeComponent();
        }
        public string sort_tarih,ay,yil;
        public static int secili_index;
        public static Boolean zaman_farkli_mi;
        private void btnYemek_Ekle_Click(object sender, EventArgs e)
        {
            Yemek_Ekle yemek_ekle = new Yemek_Ekle();
            yemek_ekle.Show();
        }
        public void Global_default()
        {
            //sort_tarih = "";
            ay = "";
            yil = "";
            secili_index = 0;
            zaman_farkli_mi = false;
        }
        private void UC_Menu_Olustur_Load(object sender, EventArgs e)
        {
            Global_default();
            comboBox1.SelectedText = "Yemek Seçiniz!";
            comboBox2.SelectedText = "Yemek Seçiniz!";
            comboBox3.SelectedText = "Yemek Seçiniz!";
            comboBox4.SelectedText = "Yemek Seçiniz!";

            Combobox_yaz();

            tarih.Text = DateTime.Now.ToLongDateString();
            dataGridView_Yaz();
        }

        public void Combobox_yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            /*
             * yemek sorgusu
             */
            SqlCommand yemek = new SqlCommand("select yemek_adi from Yemekler where tip='1'", bgl.baglanti());
            SqlDataReader yemek_reader = yemek.ExecuteReader();

            while (yemek_reader.Read())
            {
                comboBox1.Items.Add(yemek_reader["yemek_adi"]);
                comboBox2.Items.Add(yemek_reader["yemek_adi"]);
            }

            /*
             * Tatlı sorgusu
             */
            SqlCommand tatlı = new SqlCommand("select yemek_adi from Yemekler where tip='2'", bgl.baglanti());
            SqlDataReader tatlı_reader = tatlı.ExecuteReader();

            while (tatlı_reader.Read())
            {
                comboBox3.Items.Add(tatlı_reader["yemek_adi"]);

            }

            /*
             * İçecek sorgu
             */

            SqlCommand icecek = new SqlCommand("select yemek_adi from Yemekler where tip='3'", bgl.baglanti());
            SqlDataReader icecek_reader = icecek.ExecuteReader();

            while (icecek_reader.Read())
            {
                comboBox4.Items.Add(icecek_reader["yemek_adi"]);
            }

            bgl.kapat();
        }

        public void Combobox_temizle()
        {
            //comboBox1.SelectedItem = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Combobox_temizle();
            Combobox_yaz();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ay = e.Start.Month.ToString();
            yil = e.Start.Year.ToString();
            if (ay != DateTime.Now.Month.ToString() || yil != DateTime.Now.Year.ToString())
            {
                zaman_farkli_mi = true;
                dataGridView_Yaz();

            }
            else
            {
                zaman_farkli_mi = false;
                dataGridView_Yaz();
            }
                
           
            tarih.Text = e.Start.ToLongDateString();
            sort_tarih = e.Start.ToShortDateString();
            //MessageBox.Show(sort_tarih);
            //get_zaman(sort_tarih);
        }
        public string get_zaman(string date)
        {
            
            if (date!=null)
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

        public void dataGridView_Yaz()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            if (zaman_farkli_mi == true)
            {
                if (Convert.ToInt32(ay) < 10)
                    ay = "0" + ay;
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select tarih, yemek1, yemek2, yemek3, yemek4  From Gunluk_menu where (DATEPART(year,tarih)=" + yil + ") AND (DATEPART(month,tarih)=" + ay + ") Order By tarih ASC", bgl.baglanti());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlDa.Dispose();
            }
            else
            {
                string aylik_menu = DateTime.Now.Month.ToString();
                string yil_menu = DateTime.Now.Year.ToString();
                if (Convert.ToInt32(aylik_menu) < 10)
                    aylik_menu = "0" + aylik_menu;
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select tarih, yemek1, yemek2, yemek3, yemek4  From Gunluk_menu where (DATEPART(year,tarih)=" + yil_menu + ") AND (DATEPART(month,tarih)=" + aylik_menu + ") Order By tarih ASC", bgl.baglanti());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlDa.Dispose();
            }
            

            
            
            bgl.kapat();

            dataGridView1.Columns[1].HeaderText = "Yemek";
            dataGridView1.Columns[2].HeaderText = "Yemek";
            dataGridView1.Columns[3].HeaderText = "Tatlı";
            dataGridView1.Columns[4].HeaderText = "İçecek";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;


        }

        public string Yemek_Kontrol(string yemek)
        {
            if(yemek.Equals("Yemek Seçiniz!"))
            {
                return "---";
            }
            else
            {
                return yemek;
            }
        }

        

        private void btn_menu_kaydet_Click(object sender, EventArgs e)
        {
            /*
             * datagrid viewi sayfa açıldığında doldurmak için kullandım.
             */

            string yemek1 = Yemek_Kontrol(comboBox1.Text);
            string yemek2 = Yemek_Kontrol(comboBox2.Text);
            string yemek3 = Yemek_Kontrol(comboBox3.Text);
            string yemek4 = Yemek_Kontrol(comboBox4.Text);

            if (yemek1=="---" && yemek2 == "---" && yemek3 == "---" && yemek4 == "---")
            {
                MessageBox.Show("Yemek Seçmediniz");
            }
            else
            {
                string temp;
                if (yemek1 == "---" && yemek2 != "---")
                {
                    temp = yemek2;
                    yemek2 = "---";
                    yemek1 = temp;
                }

                string aylik_menu = DateTime.Now.Month.ToString();
                string yil_menu = DateTime.Now.Year.ToString();
                if (Convert.ToInt32(aylik_menu) < 10)
                    aylik_menu = "0" + aylik_menu;

                string zaman;

                if (sort_tarih != null)
                    zaman = get_zaman(sort_tarih);
                else
                    zaman = get_zaman(DateTime.Now.ToShortDateString());

                SqlBaglantisi bgl = new SqlBaglantisi();

                SqlCommand kontrol = new SqlCommand("select * from Gunluk_menu where tarih='" + zaman + "'", bgl.baglanti());
                SqlDataReader kontrol_reader = kontrol.ExecuteReader();

                string tmp_yemek1, tmp_yemek2, tmp_yemek3, tmp_yemek4;
                tmp_yemek1 = yemek1.Replace("---", " ");
                tmp_yemek2 = yemek2.Replace("---", " ");
                tmp_yemek3 = yemek3.Replace("---", " ");
                tmp_yemek4 = yemek4.Replace("---", " ");
                if (kontrol_reader.HasRows == true)
                {
                    
                    

                    SqlCommand guncelle = new SqlCommand("Update Gunluk_menu Set yemek1 ='" + tmp_yemek1 + "', yemek2 ='" + tmp_yemek2 + "',yemek3='" + tmp_yemek3 + "',yemek4='" + tmp_yemek4 + "' where tarih='" + zaman + "'", bgl.baglanti());
                    SqlDataReader guncelle_reader = guncelle.ExecuteReader();
                    MessageBox.Show(zaman + " Tarihli kayıt güncellendi!!");
                    dataGridView_Yaz();
                }
                else
                {
                    SqlCommand komut = new SqlCommand("insert into Gunluk_menu(yemek1, yemek2, yemek3, yemek4, tarih) values('" + tmp_yemek1 + "','" + tmp_yemek2 + "','" + tmp_yemek3 + "','" + tmp_yemek4 + "','" + zaman + "')", bgl.baglanti());
                    SqlDataReader komut_reader = komut.ExecuteReader();
                    MessageBox.Show("kaydedildi.");

                    dataGridView_Yaz();

                }
                bgl.kapat();
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(dataGridView1.RowCount > 0)
            {
                string zaman = dataGridView1.Rows[secili_index].Cells[0].Value.ToString();
                string[] date = zaman.Split(' ');
                string tarih = get_zaman(date[0]);

                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("DELETE From Gunluk_menu where tarih='" + tarih + "'", bgl.baglanti());
                SqlDataReader komut_reader = komut.ExecuteReader();
                while (komut_reader.Read())
                { }
                bgl.kapat();
                MessageBox.Show(date[0] + " Tarihli kayıt Silindi!!");
                dataGridView_Yaz();
            }
            else
            {
                MessageBox.Show("Liste Boş!!");
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            secili_index = e.RowIndex;
            
        }

    }
}
