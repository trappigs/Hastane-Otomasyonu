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
    public partial class HastaForm : Form
    {
        public HastaForm()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            // Paneli temizle
            panel2.Controls.Clear();

            // Formu panele ekle
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAl randevuAl = new RandevuAl();
            ShowForm(randevuAl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuGoruntule randevuGoruntule = new RandevuGoruntule();
            ShowForm(randevuGoruntule);
        }
    }
}
