namespace Emniyet_Otomasyon
{
    partial class Talep_Istek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Talep_Istek));
            this.talepdata = new System.Windows.Forms.DataGridView();
            this.talepBut = new System.Windows.Forms.Button();
            this.izinBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.talepdata)).BeginInit();
            this.SuspendLayout();
            // 
            // talepdata
            // 
            this.talepdata.AllowUserToAddRows = false;
            this.talepdata.AllowUserToDeleteRows = false;
            this.talepdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.talepdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talepdata.Location = new System.Drawing.Point(21, 36);
            this.talepdata.MultiSelect = false;
            this.talepdata.Name = "talepdata";
            this.talepdata.ReadOnly = true;
            this.talepdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.talepdata.Size = new System.Drawing.Size(445, 150);
            this.talepdata.TabIndex = 0;
            this.talepdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepdata_CellContentClick);
            this.talepdata.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepdata_CellContentDoubleClick);
            // 
            // talepBut
            // 
            this.talepBut.Location = new System.Drawing.Point(391, 218);
            this.talepBut.Name = "talepBut";
            this.talepBut.Size = new System.Drawing.Size(75, 23);
            this.talepBut.TabIndex = 1;
            this.talepBut.Text = "Talep İstekler";
            this.talepBut.UseVisualStyleBackColor = true;
            this.talepBut.Click += new System.EventHandler(this.talepBut_Click);
            // 
            // izinBut
            // 
            this.izinBut.Enabled = false;
            this.izinBut.Location = new System.Drawing.Point(21, 218);
            this.izinBut.Name = "izinBut";
            this.izinBut.Size = new System.Drawing.Size(75, 23);
            this.izinBut.TabIndex = 2;
            this.izinBut.Text = "Onayla";
            this.izinBut.UseVisualStyleBackColor = true;
            this.izinBut.Click += new System.EventHandler(this.izinBut_Click);
            // 
            // Talep_Istek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.izinBut);
            this.Controls.Add(this.talepBut);
            this.Controls.Add(this.talepdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 35);
            this.Name = "Talep_Istek";
            this.Text = "Talep_Istek";
            this.Load += new System.EventHandler(this.Talep_Istek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.talepdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView talepdata;
        private System.Windows.Forms.Button talepBut;
        private System.Windows.Forms.Button izinBut;
    }
}