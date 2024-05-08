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
    public partial class DoktorDuzenle : Form
    {
        public DoktorDuzenle()
        {
            InitializeComponent();
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            List<Control> kriterler = new List<Control>
            {
                doktor_tc,
                ad,
                soyad,
                tel,
                email,
                brans,
                il_adi,
                ilce_adi,
                mahalle_adi,
                sokak_adi,
                bina_no,
                daire_no,
                acik_adres
            };

            if (Erkek.Checked)
            {
                kriterler.Add(Erkek);
            }
            else if (Kadın.Checked)
            {
                kriterler.Add(Kadın);
            }
            dataGridView1.DataSource = sqlKisi.KisiGetir("doktor", kriterler);
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = false;
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].Visible = false;
            dataGridView1.Columns[dataGridView1.ColumnCount - 3].Visible = false;
        }

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            sqlKisi.DataGridViewToCellList(dataGridView1, "doktor");
        }



        private void DoktorDuzenle_Load(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(poliklinikComboBox, "poliklinik", sqlBransPol.polGetir());

            sqlAdres.ilListele(il_adi);
        }

        private void poliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlGenel.comboBoxaDtGetir(brans, "brans", sqlBransPol.bransGetir(poliklinikComboBox.Text));
        }

        private void il_adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.ilceListele(il_adi, ilce_adi);
        }

        bool sayac = true;
        private void ilce_adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlAdres.mahalleListele(ilce_adi, mahalle_adi);

            if (sayac == true)
            {
                il_adi.Text = "";
                ilce_adi.Text = "";
                mahalle_adi.Text = "";
                sayac = false;
            }
        }
    }
}
