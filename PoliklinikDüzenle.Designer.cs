namespace hastane_otomasyonu
{
    partial class PoliklinikDüzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.duzenleButton = new System.Windows.Forms.Button();
            this.yeniPolAdiTextBox = new System.Windows.Forms.TextBox();
            this.poliklinikComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yeni Poliklinik Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Poliklinikler";
            // 
            // duzenleButton
            // 
            this.duzenleButton.Location = new System.Drawing.Point(54, 173);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(75, 23);
            this.duzenleButton.TabIndex = 9;
            this.duzenleButton.Text = "Düzenle";
            this.duzenleButton.UseVisualStyleBackColor = true;
            this.duzenleButton.Click += new System.EventHandler(this.duzenleButton_Click);
            // 
            // yeniPolAdiTextBox
            // 
            this.yeniPolAdiTextBox.Location = new System.Drawing.Point(54, 121);
            this.yeniPolAdiTextBox.Name = "yeniPolAdiTextBox";
            this.yeniPolAdiTextBox.Size = new System.Drawing.Size(100, 22);
            this.yeniPolAdiTextBox.TabIndex = 8;
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Location = new System.Drawing.Point(54, 56);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(128, 24);
            this.poliklinikComboBox.TabIndex = 7;
            // 
            // PoliklinikDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duzenleButton);
            this.Controls.Add(this.yeniPolAdiTextBox);
            this.Controls.Add(this.poliklinikComboBox);
            this.Name = "PoliklinikDüzenle";
            this.Text = "PoliklinikDüzenle";
            this.Load += new System.EventHandler(this.PoliklinikDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button duzenleButton;
        private System.Windows.Forms.TextBox yeniPolAdiTextBox;
        private System.Windows.Forms.ComboBox poliklinikComboBox;
    }
}