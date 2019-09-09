namespace Emniyet_Otomasyon
{
    partial class KullanıcıKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıKayıt));
            this.adLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.sicilLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.siftekLab = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.sicilText = new System.Windows.Forms.TextBox();
            this.kaydetBut = new System.Windows.Forms.Button();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.sifTekText = new System.Windows.Forms.TextBox();
            this.rutLab = new System.Windows.Forms.Label();
            this.ıdLab = new System.Windows.Forms.Label();
            this.ıdText = new System.Windows.Forms.TextBox();
            this.rutText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(24, 54);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(23, 13);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(24, 89);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(37, 13);
            this.soyadLabel.TabIndex = 1;
            this.soyadLabel.Text = "Soyad";
            // 
            // sicilLabel
            // 
            this.sicilLabel.AutoSize = true;
            this.sicilLabel.Location = new System.Drawing.Point(24, 132);
            this.sicilLabel.Name = "sicilLabel";
            this.sicilLabel.Size = new System.Drawing.Size(46, 13);
            this.sicilLabel.TabIndex = 2;
            this.sicilLabel.Text = "Sicil No:";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Location = new System.Drawing.Point(24, 174);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(31, 13);
            this.sifreLabel.TabIndex = 3;
            this.sifreLabel.Text = "Şifre:";
            // 
            // siftekLab
            // 
            this.siftekLab.AutoSize = true;
            this.siftekLab.Location = new System.Drawing.Point(24, 214);
            this.siftekLab.Name = "siftekLab";
            this.siftekLab.Size = new System.Drawing.Size(65, 13);
            this.siftekLab.TabIndex = 4;
            this.siftekLab.Text = "Şifre Tekrar:";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(90, 51);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(100, 20);
            this.adText.TabIndex = 5;
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(90, 89);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(100, 20);
            this.soyadText.TabIndex = 6;
            // 
            // sicilText
            // 
            this.sicilText.Location = new System.Drawing.Point(90, 132);
            this.sicilText.MaxLength = 11;
            this.sicilText.Name = "sicilText";
            this.sicilText.Size = new System.Drawing.Size(100, 20);
            this.sicilText.TabIndex = 7;
            this.sicilText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sicilText_KeyPress);
            // 
            // kaydetBut
            // 
            this.kaydetBut.Location = new System.Drawing.Point(261, 275);
            this.kaydetBut.Name = "kaydetBut";
            this.kaydetBut.Size = new System.Drawing.Size(91, 37);
            this.kaydetBut.TabIndex = 8;
            this.kaydetBut.Text = "Kaydet";
            this.kaydetBut.UseVisualStyleBackColor = true;
            this.kaydetBut.Click += new System.EventHandler(this.kaydetBut_Click);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(90, 174);
            this.sifreText.MaxLength = 14;
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(100, 20);
            this.sifreText.TabIndex = 9;
            // 
            // sifTekText
            // 
            this.sifTekText.Location = new System.Drawing.Point(90, 212);
            this.sifTekText.MaxLength = 14;
            this.sifTekText.Name = "sifTekText";
            this.sifTekText.Size = new System.Drawing.Size(100, 20);
            this.sifTekText.TabIndex = 10;
            // 
            // rutLab
            // 
            this.rutLab.AutoSize = true;
            this.rutLab.Location = new System.Drawing.Point(24, 254);
            this.rutLab.Name = "rutLab";
            this.rutLab.Size = new System.Drawing.Size(36, 13);
            this.rutLab.TabIndex = 11;
            this.rutLab.Text = "Rütbe";
            // 
            // ıdLab
            // 
            this.ıdLab.AutoSize = true;
            this.ıdLab.Location = new System.Drawing.Point(24, 25);
            this.ıdLab.Name = "ıdLab";
            this.ıdLab.Size = new System.Drawing.Size(18, 13);
            this.ıdLab.TabIndex = 12;
            this.ıdLab.Text = "ID";
            // 
            // ıdText
            // 
            this.ıdText.Location = new System.Drawing.Point(90, 22);
            this.ıdText.MaxLength = 11;
            this.ıdText.Name = "ıdText";
            this.ıdText.Size = new System.Drawing.Size(100, 20);
            this.ıdText.TabIndex = 13;
            // 
            // rutText
            // 
            this.rutText.Location = new System.Drawing.Point(90, 251);
            this.rutText.MaxLength = 1;
            this.rutText.Name = "rutText";
            this.rutText.Size = new System.Drawing.Size(100, 20);
            this.rutText.TabIndex = 14;
            this.rutText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rutText_KeyPress);
            // 
            // KullanıcıKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 417);
            this.Controls.Add(this.rutText);
            this.Controls.Add(this.ıdText);
            this.Controls.Add(this.ıdLab);
            this.Controls.Add(this.rutLab);
            this.Controls.Add(this.sifTekText);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kaydetBut);
            this.Controls.Add(this.sicilText);
            this.Controls.Add(this.soyadText);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.siftekLab);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.sicilLabel);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullanıcıKayıt";
            this.Text = "KullanıcıKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label sicilLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label siftekLab;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.TextBox sicilText;
        private System.Windows.Forms.Button kaydetBut;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox sifTekText;
        private System.Windows.Forms.Label rutLab;
        private System.Windows.Forms.Label ıdLab;
        private System.Windows.Forms.TextBox ıdText;
        private System.Windows.Forms.TextBox rutText;
    }
}