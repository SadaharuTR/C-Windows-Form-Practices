using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gunSec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiğiniz gün: " + combo_gunler.SelectedItem.ToString() + "\nSeçtiğiniz Index: " + combo_gunler.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_gunler.Items.Add("Pazartesi");
            combo_gunler.Items.Add("Salı");
            combo_gunler.Items.Add("Çarşamba");
            combo_gunler.Items.Add("Perşembe");
            combo_gunler.Items.Add("Cuma");
            combo_gunler.Items.Add("Cumartesi");
            combo_gunler.Items.Add("Pazar");
        }
    }
}
