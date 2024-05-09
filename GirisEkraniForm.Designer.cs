namespace hastane_otomasyonu
{
    partial class GirisEkraniForm
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
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(93, 89);
            this.tcTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(132, 22);
            this.tcTextBox.TabIndex = 0;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(94, 170);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(132, 22);
            this.sifreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(89, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(89, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // girisYapButton
            // 
            this.girisYapButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.girisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.girisYapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.girisYapButton.Location = new System.Drawing.Point(113, 234);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(4);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(84, 37);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // GirisEkraniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(340, 310);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.tcTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisEkraniForm";
            this.Text = "Giriş Formu";
            this.Load += new System.EventHandler(this.GirisEkraniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisYapButton;
    }
}