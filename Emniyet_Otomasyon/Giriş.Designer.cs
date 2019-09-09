namespace Emniyet_Otomasyon
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sicilText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.kayıtlinklabel = new System.Windows.Forms.LinkLabel();
            this.girisBut = new System.Windows.Forms.Button();
            this.sifremiunuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // sicilText
            // 
            this.sicilText.Location = new System.Drawing.Point(95, 52);
            this.sicilText.MaxLength = 11;
            this.sicilText.Name = "sicilText";
            this.sicilText.Size = new System.Drawing.Size(117, 20);
            this.sicilText.TabIndex = 2;
            this.sicilText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.sicilText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sicilText_KeyPress);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(95, 97);
            this.sifreText.MaxLength = 14;
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(117, 20);
            this.sifreText.TabIndex = 3;
            this.sifreText.UseSystemPasswordChar = true;
            // 
            // kayıtlinklabel
            // 
            this.kayıtlinklabel.AutoSize = true;
            this.kayıtlinklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtlinklabel.Location = new System.Drawing.Point(92, 222);
            this.kayıtlinklabel.Name = "kayıtlinklabel";
            this.kayıtlinklabel.Size = new System.Drawing.Size(78, 20);
            this.kayıtlinklabel.TabIndex = 4;
            this.kayıtlinklabel.TabStop = true;
            this.kayıtlinklabel.Text = "Kayıt Ol !";
            this.kayıtlinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // girisBut
            // 
            this.girisBut.Location = new System.Drawing.Point(201, 149);
            this.girisBut.Name = "girisBut";
            this.girisBut.Size = new System.Drawing.Size(87, 34);
            this.girisBut.TabIndex = 5;
            this.girisBut.Text = "Giriş";
            this.girisBut.UseVisualStyleBackColor = true;
            this.girisBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifremiunuttum
            // 
            this.sifremiunuttum.Location = new System.Drawing.Point(95, 149);
            this.sifremiunuttum.Name = "sifremiunuttum";
            this.sifremiunuttum.Size = new System.Drawing.Size(87, 34);
            this.sifremiunuttum.TabIndex = 6;
            this.sifremiunuttum.Text = "Şifremi Unuttum";
            this.sifremiunuttum.UseVisualStyleBackColor = true;
            this.sifremiunuttum.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 321);
            this.Controls.Add(this.sifremiunuttum);
            this.Controls.Add(this.girisBut);
            this.Controls.Add(this.kayıtlinklabel);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.sicilText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sicilText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.LinkLabel kayıtlinklabel;
        private System.Windows.Forms.Button girisBut;
        private System.Windows.Forms.Button sifremiunuttum;
    }
}

