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
    public partial class BransEkle : Form
    {
        public BransEkle()
        {
            InitializeComponent();
        }

        Dictionary<string, string> bransPolDictionary = new Dictionary<string, string>();
        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(comboBox1.Text + " - " + textBox1.Text);
                textBox1.Focus();
                bransPolDictionary.Add(textBox1.Text, comboBox1.Text);
            }

            textBox1.Text = "";
        }



        private void kaydetButton_Click(object sender, EventArgs e)
        {
            foreach (var item in bransPolDictionary)
            {
                MessageBox.Show(item.Key + " --- " + item.Value);
            }
            sqlBransPol.bransEkle(bransPolDictionary);
            listBox1.Items.Clear();
            bransPolDictionary.Clear();
        }

        private void BransEkle_Load(object sender, EventArgs e)
        {
            // Poliklinikleri DataTable olarak al
            DataTable poliklinikler = sqlBransPol.polGetir();

            // ComboBox'a poliklinikler tablosunu bağla
            comboBox1.DataSource = poliklinikler;

            // ComboBox'ta hangi sütunun görüntüleneceğini belirle
            comboBox1.DisplayMember = "poliklinik";

            // ComboBox'ta hangi sütunun seçilen öğenin değeri olacağını belirle
            comboBox1.ValueMember = "poliklinik";
        }

        public void bransGetir(ComboBox getir, string getirilecekSutunAdi)
        {
            // Poliklinikleri DataTable olarak al
            DataTable poliklinikler = sqlBransPol.polGetir();

            // ComboBox'a poliklinikler tablosunu bağla
            getir.DataSource = poliklinikler;

            // ComboBox'ta hangi sütunun görüntüleneceğini belirle
            getir.DisplayMember = "poliklinik";

            // ComboBox'ta hangi sütunun seçilen öğenin değeri olacağını belirle
            getir.ValueMember = "poliklinik";
        }

    }
}
