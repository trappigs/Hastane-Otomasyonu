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
    public partial class PoliklinikDüzenle : Form
    {
        public PoliklinikDüzenle()
        {
            InitializeComponent();
        }

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            sqlBransPol.polDuzenle(poliklinikComboBox.Text, yeniPolAdiTextBox.Text);
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());

            yeniPolAdiTextBox.Text = "";
        }

        private void PoliklinikDüzenle_Load(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());
        }
    }
}
