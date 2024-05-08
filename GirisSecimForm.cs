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
    public partial class GirisSecimForm : Form
    {
        public GirisSecimForm()
        {
            InitializeComponent();
        }

        private void doktorGirisButton_Click(object sender, EventArgs e)
        {
            giris();

            sqlAuth.kisi = "doktor";
        }

        private void hastaGirisButton_Click(object sender, EventArgs e)
        {
            giris();

            sqlAuth.kisi = "hasta";
        }

        private void personelGirisButton_Click(object sender, EventArgs e)
        {
            giris();

            sqlAuth.kisi = "personel";
        }

        public void giris()
        {
            // Yeni GirisEkraniFormu oluştur
            GirisEkraniForm girisEkranFormu = new GirisEkraniForm();

            this.Hide();

            // Yeni formu göster
            girisEkranFormu.Show();
        }

    }
}
