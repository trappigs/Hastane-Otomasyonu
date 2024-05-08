namespace hastane_otomasyonu
{
    partial class RandevuAl
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
            this.poliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doktorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randevuSaatComboBox = new System.Windows.Forms.ComboBox();
            this.randevuAlButton = new System.Windows.Forms.Button();
            this.randevuTarihidateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Location = new System.Drawing.Point(38, 50);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(121, 21);
            this.poliklinikComboBox.TabIndex = 0;
            this.poliklinikComboBox.SelectedIndexChanged += new System.EventHandler(this.poliklinikComboBox_SelectedIndexChanged);
            // 
            // bransComboBox
            // 
            this.bransComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(38, 110);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(121, 21);
            this.bransComboBox.TabIndex = 1;
            this.bransComboBox.SelectedIndexChanged += new System.EventHandler(this.bransComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poliklinik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor";
            // 
            // doktorComboBox
            // 
            this.doktorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doktorComboBox.FormattingEnabled = true;
            this.doktorComboBox.Location = new System.Drawing.Point(38, 176);
            this.doktorComboBox.Name = "doktorComboBox";
            this.doktorComboBox.Size = new System.Drawing.Size(121, 21);
            this.doktorComboBox.TabIndex = 4;
            this.doktorComboBox.SelectedIndexChanged += new System.EventHandler(this.doktorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Randevu Saati";
            // 
            // randevuSaatComboBox
            // 
            this.randevuSaatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randevuSaatComboBox.FormattingEnabled = true;
            this.randevuSaatComboBox.Location = new System.Drawing.Point(210, 110);
            this.randevuSaatComboBox.Name = "randevuSaatComboBox";
            this.randevuSaatComboBox.Size = new System.Drawing.Size(121, 21);
            this.randevuSaatComboBox.TabIndex = 6;
            // 
            // randevuAlButton
            // 
            this.randevuAlButton.Location = new System.Drawing.Point(234, 189);
            this.randevuAlButton.Name = "randevuAlButton";
            this.randevuAlButton.Size = new System.Drawing.Size(75, 23);
            this.randevuAlButton.TabIndex = 8;
            this.randevuAlButton.Text = "Randevu Al";
            this.randevuAlButton.UseVisualStyleBackColor = true;
            this.randevuAlButton.Click += new System.EventHandler(this.randevuAlButton_Click);
            // 
            // randevuTarihidateTimePicker
            // 
            this.randevuTarihidateTimePicker.Location = new System.Drawing.Point(210, 50);
            this.randevuTarihidateTimePicker.Name = "randevuTarihidateTimePicker";
            this.randevuTarihidateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.randevuTarihidateTimePicker.TabIndex = 9;
            this.randevuTarihidateTimePicker.ValueChanged += new System.EventHandler(this.randevuTarihidateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 237);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randevuTarihidateTimePicker);
            this.Controls.Add(this.randevuAlButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randevuSaatComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(this.poliklinikComboBox);
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox poliklinikComboBox;
        private System.Windows.Forms.ComboBox bransComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doktorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox randevuSaatComboBox;
        private System.Windows.Forms.Button randevuAlButton;
        private System.Windows.Forms.DateTimePicker randevuTarihidateTimePicker;
        private System.Windows.Forms.Label label5;
    }
}