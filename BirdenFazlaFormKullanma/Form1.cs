using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaFormKullanma
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

            if (kullaniciAdi.ToLower() == "ahmet" && sifre == "1")
            {
                Anasayfa anasayfa = new Anasayfa(); 
                anasayfa.lbl_deger.Text = kullaniciAdi.ToUpper() + " Reyiz";
                anasayfa.Show();

                //this: şu anda üzerinde bulunmış olduğum form anlamına gelir.
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
