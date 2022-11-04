using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stockSayfasınaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm();
            stock.Show();
            this.Hide();
        }

        private void uygulamadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
