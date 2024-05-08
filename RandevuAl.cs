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
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void randevuAlButton_Click(object sender, EventArgs e)
        {
            // son parametreye hasta tc yi getireceğim
            // hasta tc yi getirmek için giriş yapma ekranını tasarlayıp sqlGenel sınıfında hastanın tc bilgisini public static olarak string bir
            // değişkende tutacağım ve son parametreye bu string değişkeni gireceğim
            sqlRandevu.RandevuAl(doktorComboBox, randevuTarihidateTimePicker, randevuSaatComboBox, sqlAuth.tc);
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            randevuTarihidateTimePicker.MinDate = DateTime.Today; // Bugünün tarihi
            randevuTarihidateTimePicker.MaxDate = DateTime.MaxValue;

            sqlRandevu.RandevuDoldurGenel();
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());
        }

        private void poliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(bransComboBox, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));
        }

        private void bransComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.VeriDoldur("select CONCAT(ad, ' ', soyad) AS 'adSoyad', doktor_tc FROM DOKTORLAR where brans = '" + bransComboBox.Text + "'", "adSoyad", "doktor_tc", "doktorlar", doktorComboBox);
        }

        private void doktorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlRandevu.ComboBoxaRandevuGetir(randevuSaatComboBox, doktorComboBox, randevuTarihidateTimePicker);
            if (randevuSaatComboBox.Text == "")
            {
                label5.Text = "Randevu bulunamadı";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void randevuTarihidateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sqlRandevu.ComboBoxaRandevuGetir(randevuSaatComboBox, doktorComboBox, randevuTarihidateTimePicker);
                if (randevuSaatComboBox.Text == "")
                {
                    label5.Text = "Randevu bulunamadı";
                }
                else
                {
                    label5.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
