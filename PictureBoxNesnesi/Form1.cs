using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_adi.Text;
            sifre = txt_sifre.Text;

            if (kullaniciAdi.ToLower() == "enes" && sifre == "1")
            {
                MessageBox.Show("Başarılı giriş.", "Bilgilendirme");
            }
            else { 
                MessageBox.Show("Yanlış ad veya şifre.", "Bilgilendirme.");
                pictureBox1.Image = Image.FromFile("C:\\Users\\Cagatay\\Desktop\\indir.jfif");
            }
        }
    }
}
