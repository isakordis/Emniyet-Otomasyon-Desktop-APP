namespace Emniyet_Otomasyon
{
    partial class Nobet_Yaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nobet_Yaz));
            this.label1 = new System.Windows.Forms.Label();
            this.mahallelab = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.mahalleCombo = new System.Windows.Forms.ComboBox();
            this.kaydetBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mekanCombo = new System.Windows.Forms.ComboBox();
            this.ililceCombo = new System.Windows.Forms.ComboBox();
            this.ililcelab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görevli İsmi Soyismi:";
            // 
            // mahallelab
            // 
            this.mahallelab.AutoSize = true;
            this.mahallelab.Location = new System.Drawing.Point(39, 109);
            this.mahallelab.Name = "mahallelab";
            this.mahallelab.Size = new System.Drawing.Size(47, 13);
            this.mahallelab.TabIndex = 1;
            this.mahallelab.Text = "Mahalle:";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(144, 61);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(121, 20);
            this.adText.TabIndex = 2;
            // 
            // mahalleCombo
            // 
            this.mahalleCombo.FormattingEnabled = true;
            this.mahalleCombo.Location = new System.Drawing.Point(144, 106);
            this.mahalleCombo.Name = "mahalleCombo";
            this.mahalleCombo.Size = new System.Drawing.Size(121, 21);
            this.mahalleCombo.TabIndex = 3;
            this.mahalleCombo.SelectedIndexChanged += new System.EventHandler(this.mahalleCombo_SelectedIndexChanged);
            // 
            // kaydetBut
            // 
            this.kaydetBut.Location = new System.Drawing.Point(190, 245);
            this.kaydetBut.Name = "kaydetBut";
            this.kaydetBut.Size = new System.Drawing.Size(75, 44);
            this.kaydetBut.TabIndex = 4;
            this.kaydetBut.Text = "Kaydet";
            this.kaydetBut.UseVisualStyleBackColor = true;
            this.kaydetBut.Click += new System.EventHandler(this.kaydetBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mekan:";
            // 
            // mekanCombo
            // 
            this.mekanCombo.FormattingEnabled = true;
            this.mekanCombo.Location = new System.Drawing.Point(144, 152);
            this.mekanCombo.Name = "mekanCombo";
            this.mekanCombo.Size = new System.Drawing.Size(121, 21);
            this.mekanCombo.TabIndex = 6;
            // 
            // ililceCombo
            // 
            this.ililceCombo.FormattingEnabled = true;
            this.ililceCombo.Location = new System.Drawing.Point(148, 200);
            this.ililceCombo.Name = "ililceCombo";
            this.ililceCombo.Size = new System.Drawing.Size(121, 21);
            this.ililceCombo.TabIndex = 7;
            // 
            // ililcelab
            // 
            this.ililcelab.AutoSize = true;
            this.ililcelab.Location = new System.Drawing.Point(39, 203);
            this.ililcelab.Name = "ililcelab";
            this.ililcelab.Size = new System.Drawing.Size(32, 13);
            this.ililcelab.TabIndex = 8;
            this.ililcelab.Text = "İl-İlçe";
            // 
            // Nobet_Yaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 316);
            this.Controls.Add(this.ililcelab);
            this.Controls.Add(this.ililceCombo);
            this.Controls.Add(this.mekanCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaydetBut);
            this.Controls.Add(this.mahalleCombo);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.mahallelab);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nobet_Yaz";
            this.Text = "Nobet_Yaz";
            this.Load += new System.EventHandler(this.Nobet_Yaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mahallelab;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.ComboBox mahalleCombo;
        private System.Windows.Forms.Button kaydetBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mekanCombo;
        private System.Windows.Forms.ComboBox ililceCombo;
        private System.Windows.Forms.Label ililcelab;
    }
}