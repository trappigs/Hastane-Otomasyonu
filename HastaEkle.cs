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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {
            sqlAdres.ilListele(ilComboBox);
        }

        private void ilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.ilceListele(ilComboBox, ilceComboBox);
        }

        private void ilceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.mahalleListele(ilceComboBox, mahalleComboBox);
        }

        
        private void ekleButton_Click(object sender, EventArgs e)
        {
            string cinsiyet = null;
            if (radioButton1.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "Kadın";
            }

            sqlKisi.KisiEkle("hasta", tcTextBox.Text, adTextBox.Text, soyadTextBox.Text, tel: telTextBox.Text, emailTextBox.Text, dogum_tarihi_dt, cinsiyet: cinsiyet, "", sifreTextBox.Text);
            sqlKisi.AdresEkle("hasta", ilComboBox.Text, ilceComboBox.Text, mahalleComboBox.Text, sokakTextBox.Text, binaNoTextBox.Text, daireNoTextBox.Text, acikAdresTextBox.Text, tcTextBox.Text);
        }
    }
}
