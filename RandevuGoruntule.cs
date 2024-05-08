using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hastane_otomasyonu
{
    public partial class RandevuGoruntule : Form
    {
        public RandevuGoruntule()
        {
            InitializeComponent();
        }

        private void poliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(brans, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));

        }

        private void RandevuGoruntule_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;



            // Bugünün tarihini al
            DateTime bugun = DateTime.Today;

            // ComboBox'ı temizle
            randevu_gun.Items.Clear();

            // 7 gün boyunca döngü oluştur
            for (int i = 0; i < 7; i++)
            {
                // Güncel tarih ve saat bilgisini al
                DateTime tarih = bugun.AddDays(i);

                // Yıl, ay ve günü ComboBox'a ekle
                randevu_gun.Items.Add(tarih.ToString("yyyy-MM-dd"));
            }



            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());
        }

        private void bransComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.VeriDoldur("select CONCAT(ad, ' ', soyad) AS 'adSoyad', doktor_tc FROM DOKTORLAR where brans = '" + brans.Text + "'", "adSoyad", "doktor_tc", "doktorlar", doktor_tc);
        }

        private void doktorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlRandevu.RandevuGetir(doktor_tc, randevu_saat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlRandevu.RandevuGetir(dataGridView1,new List<Control> {brans, doktor_tc, randevu_saat, randevu_gun} );
        }
    }
}
