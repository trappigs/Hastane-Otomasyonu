using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace hastane_otomasyonu
{
    public partial class HastaForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);

        }




        public HastaForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void ShowForm(Form form)
        {
            // Paneli temizle
            panel1.Controls.Clear();

            // Formu panele ekle
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
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

        private void HastaForm_Load(object sender, EventArgs e)
        {
            //CustomWindow(Color.FromArgb(24), Color.FromArgb(30), Color.FromArgb(54), Handle);
        }
        
        public void ozellik(Panel pnl, Button btn)
        {
            pnl.Height = btn.Height;
            pnl.Top = btn.Top;
            pnl.Left = btn.Left;

            btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        public void renkDegis(Button btn)
        {
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            ozellik(PnlNav, button7);

            RandevuGoruntule randevuGoruntule = new RandevuGoruntule();
            ShowForm(randevuGoruntule);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ozellik(PnlNav, button8);

            RandevuAl randevuAl = new RandevuAl();
            ShowForm(randevuAl);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ozellik(PnlNav, button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ozellik(PnlNav, button10);
        }

        private void button7_Leave(object sender, EventArgs e)
        {
            renkDegis(button7);
        }

        private void button8_Leave(object sender, EventArgs e)
        {
            renkDegis(button8);
        }

        private void button9_Leave(object sender, EventArgs e)
        {
            renkDegis(button9);
        }

        private void button10_Leave(object sender, EventArgs e)
        {
            renkDegis(button10);
        }

    }
}
