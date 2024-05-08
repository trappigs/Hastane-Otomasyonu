namespace hastane_otomasyonu
{
    partial class GirisSecimForm
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
            this.doktorGirisButton = new System.Windows.Forms.Button();
            this.hastaGirisButton = new System.Windows.Forms.Button();
            this.personelGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorGirisButton
            // 
            this.doktorGirisButton.Location = new System.Drawing.Point(32, 23);
            this.doktorGirisButton.Name = "doktorGirisButton";
            this.doktorGirisButton.Size = new System.Drawing.Size(122, 67);
            this.doktorGirisButton.TabIndex = 0;
            this.doktorGirisButton.Text = "Doktor Giriş";
            this.doktorGirisButton.UseVisualStyleBackColor = true;
            this.doktorGirisButton.Click += new System.EventHandler(this.doktorGirisButton_Click);
            // 
            // hastaGirisButton
            // 
            this.hastaGirisButton.Location = new System.Drawing.Point(32, 96);
            this.hastaGirisButton.Name = "hastaGirisButton";
            this.hastaGirisButton.Size = new System.Drawing.Size(122, 67);
            this.hastaGirisButton.TabIndex = 1;
            this.hastaGirisButton.Text = "Hasta Giriş";
            this.hastaGirisButton.UseVisualStyleBackColor = true;
            this.hastaGirisButton.Click += new System.EventHandler(this.hastaGirisButton_Click);
            // 
            // personelGirisButton
            // 
            this.personelGirisButton.Location = new System.Drawing.Point(32, 169);
            this.personelGirisButton.Name = "personelGirisButton";
            this.personelGirisButton.Size = new System.Drawing.Size(122, 67);
            this.personelGirisButton.TabIndex = 2;
            this.personelGirisButton.Text = "Personel Giriş";
            this.personelGirisButton.UseVisualStyleBackColor = true;
            this.personelGirisButton.Click += new System.EventHandler(this.personelGirisButton_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 248);
            this.Controls.Add(this.personelGirisButton);
            this.Controls.Add(this.hastaGirisButton);
            this.Controls.Add(this.doktorGirisButton);
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doktorGirisButton;
        private System.Windows.Forms.Button hastaGirisButton;
        private System.Windows.Forms.Button personelGirisButton;
    }
}