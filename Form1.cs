﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //DoktorEkle doktorEkle = new DoktorEkle();
            //ShowForm(doktorEkle);
        }

        private void ShowForm(Form form)
        {
            // Paneli temizle
            panel2.Controls.Clear();

            // Formu panele ekle
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoliklinikEkle polEkle = new PoliklinikEkle();
            ShowForm(polEkle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BransEkle bransEkle = new BransEkle();
            ShowForm(bransEkle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BransDuzenle bransDuzenle = new BransDuzenle();
            ShowForm(bransDuzenle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PoliklinikDüzenle polduzenle = new PoliklinikDüzenle();
            ShowForm(polduzenle);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
