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
    public partial class BransDuzenle : Form
    {
        public BransDuzenle()
        {
            InitializeComponent();
        }

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sqlBransPol.bransDuzenle(textBox1.Text, duzenlenecekBransComboBox.Text);
                sqlGenel.comboBoxaDtGetir(duzenlenecekBransComboBox, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));
            }
        }

        private void BransDuzenle_Load(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());
        }

        private void poliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(duzenlenecekBransComboBox, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));
        }
    }
}
