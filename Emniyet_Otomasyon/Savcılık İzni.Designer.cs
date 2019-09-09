namespace Emniyet_Otomasyon
{
    partial class Savcılık_İzni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Savcılık_İzni));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gonderBut = new System.Windows.Forms.Button();
            this.izintext = new System.Windows.Forms.TextBox();
            this.baslangıctarih = new System.Windows.Forms.DateTimePicker();
            this.bitistarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Nedeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İzin Tarihi:";
            // 
            // gonderBut
            // 
            this.gonderBut.Location = new System.Drawing.Point(226, 234);
            this.gonderBut.Name = "gonderBut";
            this.gonderBut.Size = new System.Drawing.Size(75, 23);
            this.gonderBut.TabIndex = 2;
            this.gonderBut.Text = "Gönder";
            this.gonderBut.UseVisualStyleBackColor = true;
            this.gonderBut.Click += new System.EventHandler(this.gonderBut_Click);
            // 
            // izintext
            // 
            this.izintext.Location = new System.Drawing.Point(107, 49);
            this.izintext.Name = "izintext";
            this.izintext.Size = new System.Drawing.Size(151, 20);
            this.izintext.TabIndex = 3;
            // 
            // baslangıctarih
            // 
            this.baslangıctarih.Location = new System.Drawing.Point(107, 87);
            this.baslangıctarih.Name = "baslangıctarih";
            this.baslangıctarih.Size = new System.Drawing.Size(151, 20);
            this.baslangıctarih.TabIndex = 4;
            this.baslangıctarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bitistarih
            // 
            this.bitistarih.Location = new System.Drawing.Point(107, 141);
            this.bitistarih.Name = "bitistarih";
            this.bitistarih.Size = new System.Drawing.Size(151, 20);
            this.bitistarih.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Son Tarih:";
            // 
            // Savcılık_İzni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bitistarih);
            this.Controls.Add(this.baslangıctarih);
            this.Controls.Add(this.izintext);
            this.Controls.Add(this.gonderBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Savcılık_İzni";
            this.Text = "Savcılık_İzni";
            this.Load += new System.EventHandler(this.Savcılık_İzni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gonderBut;
        private System.Windows.Forms.TextBox izintext;
        private System.Windows.Forms.DateTimePicker baslangıctarih;
        private System.Windows.Forms.DateTimePicker bitistarih;
        private System.Windows.Forms.Label label3;
    }
}