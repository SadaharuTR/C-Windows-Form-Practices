using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Asal_Sayı_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            for (int i = sayi1; i <= sayi2; i++) //2 sayı arasındaki asal sayıları bulmak için 
            {
                int kontrol = 0; //asal sayı kontrolü

                for (int j = 2; j < i; j++) //i sayısının 2'den başlayarak kendisinden 1 eksik olana kadar dolaş
                {
                    //1 ve kendisi hariç sayılara bölünüyor mu?
                    if(i%j == 0)
                    {
                        //bölünüyorsa asal değil
                        kontrol++;
                        break; //diğer sayılara bakma
                    }
                } //kontrol değeri 0 olarak kaldıysa hiç tam olarak bölünmemiş demektir. Yani asal sayıdır.
                if(kontrol==0 && i!=0 && i != 1)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
