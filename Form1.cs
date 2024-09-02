using KütüphaneOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_KullaniciADI.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi, Sifre = "";

            KullaniciAdi = txt_KullaniciADI.Text;
            Sifre = txt_sifre.Text;

            

            foreach (Kisi k in kisilerim)
            {
                if(KullaniciAdi.ToLower() == k.getKullaniciAdi().ToLower() && Sifre.ToLower() == k.getSifre().ToLower() && k.getYetki() == "admin")
                {
                    // admin sayfasına yönlendir.
                    AdminSayfasi adminSyafasi = new AdminSayfasi();
                    adminSyafasi.Show();
                   
                    this.Hide();
                     


                }
                else if(KullaniciAdi.ToLower() == k.getKullaniciAdi().ToLower() && Sifre.ToLower() == k.getSifre().ToLower() && k.getYetki() == "uye")
                {
                    // üye sayfasına yonlendir.
                    UyeSayfasi uyeSayfasi = new UyeSayfasi();
                    uyeSayfasi.Show();
                    
                    this.Hide();
                       
                }
                
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Duran", "Gezer",DateTime.Now,"duran","1","admin"));
            kisilerim.Add(new Kisi(2, "Enes", "Bayram", DateTime.Now, "enes", "2", "uye"));
            kisilerim.Add(new Kisi(3, "Ahmet", "Aydoğan", DateTime.Now, "ahmet", "3", "uye"));
            kisilerim.Add(new Kisi(4, "Emir", "Ateş", DateTime.Now, "emir", "4", "uye"));
            kisilerim.Add(new Kisi(5, "Talha", "Çalışkan", DateTime.Now, "talha", "5", "uye"));


        }
    }
}
