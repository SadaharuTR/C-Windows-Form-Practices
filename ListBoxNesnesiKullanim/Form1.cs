﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxNesnesiKullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çarşamba");
            listBox1.Items.Add("Perşembe");

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_ekle.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            //listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex].ToString());
        }

        private void btn_say_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listbox Count Değeri: " + listBox1.Items.Count.ToString());
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Listbox temizlendi.");
        }
    }
}
