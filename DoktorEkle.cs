using System;
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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());

            sqlAdres.ilListele(ilComboBox);
        }

        private void poliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(bransComboBox, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));
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

            sqlKisi.KisiEkle("doktor", tcTextBox.Text, adTextBox.Text, soyadTextBox.Text, tel: telTextBox.Text, emailTextBox.Text, dogum_tarihi_dt, cinsiyet: cinsiyet, bransComboBox.Text, sifreTextBox.Text);
            sqlKisi.AdresEkle("doktor", ilComboBox.Text, ilceComboBox.Text, mahalleComboBox.Text, sokakTextBox.Text, binaNoTextBox.Text, daireNoTextBox.Text, acikAdresTextBox.Text, tcTextBox.Text);
        }
    }
}
