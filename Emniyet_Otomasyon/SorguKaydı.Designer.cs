namespace Emniyet_Otomasyon
{
    partial class SorguKaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorguKaydı));
            this.adLabel = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.sorguTarih = new System.Windows.Forms.Label();
            this.sorguLabel = new System.Windows.Forms.Label();
            this.sorguText = new System.Windows.Forms.TextBox();
            this.kayıtBut = new System.Windows.Forms.Button();
            this.kimlikText = new System.Windows.Forms.TextBox();
            this.kimlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(30, 58);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(55, 13);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Suçlu Adı:";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(111, 55);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(149, 20);
            this.adText.TabIndex = 1;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(111, 163);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(149, 20);
            this.tarih.TabIndex = 2;
            // 
            // sorguTarih
            // 
            this.sorguTarih.AutoSize = true;
            this.sorguTarih.Location = new System.Drawing.Point(30, 170);
            this.sorguTarih.Name = "sorguTarih";
            this.sorguTarih.Size = new System.Drawing.Size(67, 13);
            this.sorguTarih.TabIndex = 3;
            this.sorguTarih.Text = "Sorgu Tarihi:";
            // 
            // sorguLabel
            // 
            this.sorguLabel.AutoSize = true;
            this.sorguLabel.Location = new System.Drawing.Point(30, 133);
            this.sorguLabel.Name = "sorguLabel";
            this.sorguLabel.Size = new System.Drawing.Size(38, 13);
            this.sorguLabel.TabIndex = 4;
            this.sorguLabel.Text = "Sorgu:";
            // 
            // sorguText
            // 
            this.sorguText.Location = new System.Drawing.Point(111, 126);
            this.sorguText.Name = "sorguText";
            this.sorguText.Size = new System.Drawing.Size(149, 20);
            this.sorguText.TabIndex = 5;
            // 
            // kayıtBut
            // 
            this.kayıtBut.Location = new System.Drawing.Point(185, 213);
            this.kayıtBut.Name = "kayıtBut";
            this.kayıtBut.Size = new System.Drawing.Size(75, 23);
            this.kayıtBut.TabIndex = 6;
            this.kayıtBut.Text = "Kaydet";
            this.kayıtBut.UseVisualStyleBackColor = true;
            this.kayıtBut.Click += new System.EventHandler(this.kayıtBut_Click);
            // 
            // kimlikText
            // 
            this.kimlikText.Location = new System.Drawing.Point(111, 90);
            this.kimlikText.MaxLength = 11;
            this.kimlikText.Name = "kimlikText";
            this.kimlikText.Size = new System.Drawing.Size(149, 20);
            this.kimlikText.TabIndex = 8;
            this.kimlikText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.kimlikText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlikText_KeyPress);
            // 
            // kimlik
            // 
            this.kimlik.AutoSize = true;
            this.kimlik.Location = new System.Drawing.Point(30, 93);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(54, 13);
            this.kimlik.TabIndex = 7;
            this.kimlik.Text = "Kimlik No:";
            // 
            // SorguKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 347);
            this.Controls.Add(this.kimlikText);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.kayıtBut);
            this.Controls.Add(this.sorguText);
            this.Controls.Add(this.sorguLabel);
            this.Controls.Add(this.sorguTarih);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.adLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorguKaydı";
            this.Text = "SorguKaydı";
            this.Load += new System.EventHandler(this.SorguKaydı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label sorguTarih;
        private System.Windows.Forms.Label sorguLabel;
        private System.Windows.Forms.TextBox sorguText;
        private System.Windows.Forms.Button kayıtBut;
        private System.Windows.Forms.TextBox kimlikText;
        private System.Windows.Forms.Label kimlik;
    }
}