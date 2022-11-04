using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Geri_Sayım_Aracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 60;
        int dakika = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100; //1000ms 1 sn demek
            saniye = saniye - 1;
            lbl_saniye.Text = saniye.ToString();   
            lbl_dakika.Text = (dakika-1).ToString();

            if(saniye == 0 )
            {
                dakika = dakika - 1;
                lbl_dakika.Text = dakika.ToString();
                saniye = 60;
            }

            if(lbl_dakika.Text == "-1")
            {
                timer1.Stop();
                lbl_dakika.Text = "00";
                lbl_saniye.Text = "00";

                BackColor = Color.Red;
                MessageBox.Show("Geri sayım sona erdi.");

            }
        }
    }
}
