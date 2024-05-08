namespace hastane_otomasyonu
{
    partial class BransDuzenle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.duzenleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duzenlenecekBransComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // poliklinikComboBox
            // 
            this.poliklinikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poliklinikComboBox.FormattingEnabled = true;
            this.poliklinikComboBox.Location = new System.Drawing.Point(233, 116);
            this.poliklinikComboBox.Name = "poliklinikComboBox";
            this.poliklinikComboBox.Size = new System.Drawing.Size(128, 24);
            this.poliklinikComboBox.TabIndex = 0;
            this.poliklinikComboBox.SelectedIndexChanged += new System.EventHandler(this.poliklinikComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // duzenleButton
            // 
            this.duzenleButton.Location = new System.Drawing.Point(233, 324);
            this.duzenleButton.Name = "duzenleButton";
            this.duzenleButton.Size = new System.Drawing.Size(75, 23);
            this.duzenleButton.TabIndex = 2;
            this.duzenleButton.Text = "Düzenle";
            this.duzenleButton.UseVisualStyleBackColor = true;
            this.duzenleButton.Click += new System.EventHandler(this.duzenleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poliklinikler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Branş Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Düzenlenecek Branş";
            // 
            // duzenlenecekBransComboBox
            // 
            this.duzenlenecekBransComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duzenlenecekBransComboBox.FormattingEnabled = true;
            this.duzenlenecekBransComboBox.Location = new System.Drawing.Point(233, 180);
            this.duzenlenecekBransComboBox.Name = "duzenlenecekBransComboBox";
            this.duzenlenecekBransComboBox.Size = new System.Drawing.Size(128, 24);
            this.duzenlenecekBransComboBox.TabIndex = 5;
            // 
            // BransDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.duzenlenecekBransComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duzenleButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.poliklinikComboBox);
            this.Name = "BransDuzenle";
            this.Text = "BransDuzenle";
            this.Load += new System.EventHandler(this.BransDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox poliklinikComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button duzenleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox duzenlenecekBransComboBox;
    }
}