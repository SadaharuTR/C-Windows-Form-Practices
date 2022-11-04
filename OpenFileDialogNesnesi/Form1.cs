using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialogNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            string resimYolu = openFileDialog.FileName;

            pictureBox1.Image = Image.FromFile(resimYolu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eklendi işte lanet olası.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is RichTextBox)
                    groupBox1.Controls[i].Text = string.Empty;
            }
        }
    }
}
