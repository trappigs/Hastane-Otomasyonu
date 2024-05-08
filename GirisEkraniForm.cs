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
    public partial class GirisEkraniForm : Form
    {
        public GirisEkraniForm()
        {
            InitializeComponent();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            bool girisYapildiMi = sqlAuth.kisiGiris(
                kisiBilgisi: sqlAuth.kisi,
                tcTxt: tcTextBox,
                sifre: sifreTextBox
                );

            if (girisYapildiMi == true)
            {
                // Yeni GirisEkraniFormu oluştur
                if (sqlAuth.kisi == "personel")
                {
                    PersonelForm personelFormu = new PersonelForm();

                    this.Close();
                    // Yeni formu göster
                    personelFormu.Show();
                }
                if (sqlAuth.kisi == "hasta")
                {
                    HastaForm hastaForm = new HastaForm();

                    this.Close();

                    // Yeni formu göster
                    hastaForm.Show();
                }
                if (sqlAuth.kisi == "doktor")
                {
                    DoktorForm doktorFormu = new DoktorForm();

                    this.Close();

                    // Yeni formu göster
                    doktorFormu.Show();
                }
            }
            else
            {
                MessageBox.Show("TC veya şifre yanlış.");
            }

        }

        private void GirisEkraniForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
