using Fabrikalar.UserControls;
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
    public partial class Form_Dashboard : Form
    {
        int panelGenislik;
        bool isCollapsed;
        Timer t = new Timer();

        public Form_Dashboard()
        {
            InitializeComponent();
            panelGenislik = panelLeft.Width;
            isCollapsed = false;
            UserControl_Home uch = new UserControl_Home();
            Ekle_PaneleKontrol(uch);
            Tarih.Text = DateTime.Now.ToLongDateString();
            string zaman = get_zaman();
            
            SqlBaglantisi bgl = new SqlBaglantisi();
            //bgl.baglanti();
            SqlCommand komut = new SqlCommand("Select yemek1,yemek2,yemek3,yemek4 From Gunluk_menu where tarih='"+zaman+"'", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
             while(oku.Read())
            { 
            if (oku.HasRows == true )
                yemek1.Text = oku["yemek1"].ToString() + "-" + oku["yemek2"].ToString() + "-" + oku["yemek3"].ToString() + "-" + oku["yemek4"].ToString();
            else
                yemek1.Text = "Bugünlük Sipariş Yok";
            }
            
            t.Interval = 1000;//milisecond
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
        }

       

        private void t_tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            zaman.Text = time;
        }



        public string get_zaman()
        {
            string zaman,gun,ay,yil;
            gun = DateTime.Now.Day.ToString();
            ay = DateTime.Now.Month.ToString();
            yil = DateTime.Now.Year.ToString();

            if (DateTime.Now.Day < 10)
                gun = "0"+gun;
            if (DateTime.Now.Month < 10)
                ay = "0" + ay;

            zaman = yil + "-" + ay + "-" + gun;
            return zaman;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 20;
                if(panelLeft.Width >= panelGenislik)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width - 20;
                if(panelLeft.Width <= 59 )
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PanelCubuk(Control btn)
        {
            panelcubuk.Top = btn.Top;
            panelcubuk.Height = btn.Height;
        }

        private void Ekle_PaneleKontrol(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelKontrol.Controls.Clear();
            panelKontrol.Controls.Add(c);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            PanelCubuk(btnAnasayfa);
            UserControl_Home uch = new UserControl_Home();
            Ekle_PaneleKontrol(uch);
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            PanelCubuk(btnSiparis);
            UC_Eski_Siparisler uceski_siparis = new UC_Eski_Siparisler();
            Ekle_PaneleKontrol(uceski_siparis);
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            PanelCubuk(btnMusteriEkle);
            UC_Musteri_Ekle yeni_musteri = new UC_Musteri_Ekle();
            Ekle_PaneleKontrol(yeni_musteri);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            PanelCubuk(btnAyarlar);
            UC_Ayarlar ayarlar = new UC_Ayarlar();
            Ekle_PaneleKontrol(ayarlar);
        }

        private void btnMenuOlustur_Click(object sender, EventArgs e)
        {
            PanelCubuk(btnMenuOlustur);
            UC_Menu_Olustur menu_olustur = new UC_Menu_Olustur();
            Ekle_PaneleKontrol(menu_olustur);
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
