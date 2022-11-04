using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxNesnesiKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kullanıcının girdiği verileri alıp veritabanına ekleyeceğiz.
            MessageBox.Show("Harami Kaydı eklendi.");

            for(int i = 0; i < groupBox1.Controls.Count; i++) //groupbox'un içerisindeki değer sayısı kadar dön
            {
                if (groupBox1.Controls[i] is TextBox) //textbox ise gir, yakala
                {
                    groupBox1.Controls[i].Text = string.Empty; //text'i emptyle.
                }
              
            }
        }
    }
}
