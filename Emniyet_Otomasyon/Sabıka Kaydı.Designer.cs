namespace Emniyet_Otomasyon
{
    partial class Sabıka_Kaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sabıka_Kaydı));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adıText = new System.Windows.Forms.TextBox();
            this.kimlikText = new System.Windows.Forms.TextBox();
            this.sucText = new System.Windows.Forms.TextBox();
            this.kayıtBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sucTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suçlu Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kimlik Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Suçu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adıText
            // 
            this.adıText.Location = new System.Drawing.Point(128, 91);
            this.adıText.Name = "adıText";
            this.adıText.Size = new System.Drawing.Size(100, 20);
            this.adıText.TabIndex = 5;
            // 
            // kimlikText
            // 
            this.kimlikText.Location = new System.Drawing.Point(128, 126);
            this.kimlikText.MaxLength = 11;
            this.kimlikText.Name = "kimlikText";
            this.kimlikText.Size = new System.Drawing.Size(100, 20);
            this.kimlikText.TabIndex = 7;
            this.kimlikText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlikText_KeyPress);
            // 
            // sucText
            // 
            this.sucText.Location = new System.Drawing.Point(128, 162);
            this.sucText.Name = "sucText";
            this.sucText.Size = new System.Drawing.Size(100, 20);
            this.sucText.TabIndex = 8;
            this.sucText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // kayıtBut
            // 
            this.kayıtBut.Location = new System.Drawing.Point(228, 243);
            this.kayıtBut.Name = "kayıtBut";
            this.kayıtBut.Size = new System.Drawing.Size(75, 23);
            this.kayıtBut.TabIndex = 9;
            this.kayıtBut.Text = "Kaydet";
            this.kayıtBut.UseVisualStyleBackColor = true;
            this.kayıtBut.Click += new System.EventHandler(this.kayıtBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Suç Tarihi:";
            // 
            // sucTarih
            // 
            this.sucTarih.Location = new System.Drawing.Point(128, 198);
            this.sucTarih.Name = "sucTarih";
            this.sucTarih.Size = new System.Drawing.Size(142, 20);
            this.sucTarih.TabIndex = 11;
            // 
            // Sabıka_Kaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 385);
            this.Controls.Add(this.sucTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayıtBut);
            this.Controls.Add(this.sucText);
            this.Controls.Add(this.kimlikText);
            this.Controls.Add(this.adıText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sabıka_Kaydı";
            this.Text = "Sabıka Kaydı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adıText;
        private System.Windows.Forms.TextBox kimlikText;
        private System.Windows.Forms.TextBox sucText;
        private System.Windows.Forms.Button kayıtBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker sucTarih;

    }
}