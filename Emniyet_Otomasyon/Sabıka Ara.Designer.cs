namespace Emniyet_Otomasyon
{
    partial class Sabıka_Ara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sabıka_Ara));
            this.adLabel = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.dataSuc = new System.Windows.Forms.DataGridView();
            this.araBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(12, 74);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(87, 13);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Suçlu Adı Soyadı";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(105, 70);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(100, 20);
            this.adText.TabIndex = 1;
            // 
            // dataSuc
            // 
            this.dataSuc.AllowUserToAddRows = false;
            this.dataSuc.AllowUserToDeleteRows = false;
            this.dataSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuc.Location = new System.Drawing.Point(36, 104);
            this.dataSuc.Name = "dataSuc";
            this.dataSuc.Size = new System.Drawing.Size(270, 177);
            this.dataSuc.TabIndex = 2;
            // 
            // araBut
            // 
            this.araBut.Location = new System.Drawing.Point(220, 70);
            this.araBut.Name = "araBut";
            this.araBut.Size = new System.Drawing.Size(75, 23);
            this.araBut.TabIndex = 3;
            this.araBut.Text = "Ara";
            this.araBut.UseVisualStyleBackColor = true;
            this.araBut.Click += new System.EventHandler(this.araBut_Click);
            // 
            // Sabıka_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 372);
            this.Controls.Add(this.araBut);
            this.Controls.Add(this.dataSuc);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.adLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sabıka_Ara";
            this.Text = "Sabıka_Ara";
            this.Load += new System.EventHandler(this.Sabıka_Ara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.DataGridView dataSuc;
        private System.Windows.Forms.Button araBut;
    }
}