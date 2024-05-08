namespace hastane_otomasyonu
{
    partial class RandevuGoruntule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.doktor_tc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brans = new System.Windows.Forms.ComboBox();
            this.poliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randevu_gun = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.randevu_saat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(64, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doktor";
            // 
            // doktor_tc
            // 
            this.doktor_tc.FormattingEnabled = true;
            this.doktor_tc.Location = new System.Drawing.Point(68, 220);
            this.doktor_tc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doktor_tc.Name = "doktor_tc";
            this.doktor_tc.Size = new System.Drawing.Size(160, 23);
            this.doktor_tc.TabIndex = 10;
            this.doktor_tc.SelectedIndexChanged += new System.EventHandler(this.doktorComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Branş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poliklinik";
            // 
            // brans
            // 
            this.brans.FormattingEnabled = true;
            this.brans.Location = new System.Drawing.Point(68, 144);
            this.brans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brans.Name = "brans";
            this.brans.Size = new System.Drawing.Size(160, 23);
            this.brans.TabIndex = 7;
            this.brans.SelectedIndexChanged += new System.EventHandler(this.bransComboBox_SelectedIndexChanged);
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Location = new System.Drawing.Point(68, 75);
            this.poliklinikComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(160, 23);
            this.poliklinikComboBox.TabIndex = 6;
            this.poliklinikComboBox.SelectedIndexChanged += new System.EventHandler(this.poliklinikComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(64, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Randevu Günü";
            // 
            // randevu_gun
            // 
            this.randevu_gun.FormattingEnabled = true;
            this.randevu_gun.Location = new System.Drawing.Point(68, 374);
            this.randevu_gun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randevu_gun.Name = "randevu_gun";
            this.randevu_gun.Size = new System.Drawing.Size(160, 23);
            this.randevu_gun.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 311);
            this.dataGridView1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(64, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Randevu Saati";
            // 
            // randevu_saat
            // 
            this.randevu_saat.FormattingEnabled = true;
            this.randevu_saat.Location = new System.Drawing.Point(68, 304);
            this.randevu_saat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randevu_saat.Name = "randevu_saat";
            this.randevu_saat.Size = new System.Drawing.Size(160, 23);
            this.randevu_saat.TabIndex = 16;
            // 
            // RandevuGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(937, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randevu_saat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randevu_gun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktor_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brans);
            this.Controls.Add(this.poliklinikComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RandevuGoruntule";
            this.Text = "RandevuGoruntule";
            this.Load += new System.EventHandler(this.RandevuGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doktor_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox brans;
        private System.Windows.Forms.ComboBox poliklinikComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox randevu_gun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox randevu_saat;
    }
}