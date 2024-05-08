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
    public partial class PoliklinikEkle : Form
    {
        public PoliklinikEkle()
        {
            InitializeComponent();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            sqlBransPol.polEkle(listBox1);
            listBox1.Items.Clear();
        }
    }
}
