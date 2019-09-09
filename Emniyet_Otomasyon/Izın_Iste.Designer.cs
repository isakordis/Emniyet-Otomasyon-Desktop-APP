namespace Emniyet_Otomasyon
{
    partial class Izın_Iste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izın_Iste));
            this.label1 = new System.Windows.Forms.Label();
            this.basLab = new System.Windows.Forms.Label();
            this.izinText = new System.Windows.Forms.TextBox();
            this.bitisLab = new System.Windows.Forms.Label();
            this.kayıtBut = new System.Windows.Forms.Button();
            this.baslangic = new System.Windows.Forms.DateTimePicker();
            this.bitis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Nedeni:";
            // 
            // basLab
            // 
            this.basLab.AutoSize = true;
            this.basLab.Font = new System.Drawing.Font("Matura MT Script Capitals", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.basLab.Location = new System.Drawing.Point(33, 126);
            this.basLab.Name = "basLab";
            this.basLab.Size = new System.Drawing.Size(112, 19);
            this.basLab.TabIndex = 1;
            this.basLab.Text = "İzin Başlangıç";
            // 
            // izinText
            // 
            this.izinText.Location = new System.Drawing.Point(136, 60);
            this.izinText.Name = "izinText";
            this.izinText.Size = new System.Drawing.Size(108, 20);
            this.izinText.TabIndex = 2;
            this.izinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.izinText_KeyPress);
            // 
            // bitisLab
            // 
            this.bitisLab.AutoSize = true;
            this.bitisLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisLab.Location = new System.Drawing.Point(274, 126);
            this.bitisLab.Name = "bitisLab";
            this.bitisLab.Size = new System.Drawing.Size(74, 20);
            this.bitisLab.TabIndex = 6;
            this.bitisLab.Text = "İzin Bitiş";
            // 
            // kayıtBut
            // 
            this.kayıtBut.Location = new System.Drawing.Point(199, 255);
            this.kayıtBut.Name = "kayıtBut";
            this.kayıtBut.Size = new System.Drawing.Size(97, 43);
            this.kayıtBut.TabIndex = 7;
            this.kayıtBut.Text = "Kaydet";
            this.kayıtBut.UseVisualStyleBackColor = true;
            this.kayıtBut.Click += new System.EventHandler(this.kayıtBut_Click);
            // 
            // baslangic
            // 
            this.baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangic.Location = new System.Drawing.Point(36, 171);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(200, 26);
            this.baslangic.TabIndex = 8;
            // 
            // bitis
            // 
            this.bitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitis.Location = new System.Drawing.Point(278, 171);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(200, 26);
            this.bitis.TabIndex = 9;
            // 
            // Izın_Iste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 429);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.kayıtBut);
            this.Controls.Add(this.bitisLab);
            this.Controls.Add(this.izinText);
            this.Controls.Add(this.basLab);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Izın_Iste";
            this.Text = "Izın_Iste";
            this.Load += new System.EventHandler(this.Izın_Iste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label basLab;
        private System.Windows.Forms.TextBox izinText;
        private System.Windows.Forms.Label bitisLab;
        private System.Windows.Forms.Button kayıtBut;
        private System.Windows.Forms.DateTimePicker baslangic;
        private System.Windows.Forms.DateTimePicker bitis;
    }
}