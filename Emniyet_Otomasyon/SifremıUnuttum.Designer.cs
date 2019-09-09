namespace Emniyet_Otomasyon
{
    partial class SifremıUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremıUnuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.sicilText = new System.Windows.Forms.TextBox();
            this.gosterGrid = new System.Windows.Forms.DataGridView();
            this.gosterBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gosterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No:";
            // 
            // sicilText
            // 
            this.sicilText.Location = new System.Drawing.Point(124, 73);
            this.sicilText.MaxLength = 11;
            this.sicilText.Name = "sicilText";
            this.sicilText.Size = new System.Drawing.Size(100, 20);
            this.sicilText.TabIndex = 1;
            this.sicilText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sicilText_KeyPress);
            // 
            // gosterGrid
            // 
            this.gosterGrid.AllowUserToAddRows = false;
            this.gosterGrid.AllowUserToDeleteRows = false;
            this.gosterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gosterGrid.Location = new System.Drawing.Point(39, 134);
            this.gosterGrid.Name = "gosterGrid";
            this.gosterGrid.Size = new System.Drawing.Size(213, 136);
            this.gosterGrid.TabIndex = 2;
            // 
            // gosterBut
            // 
            this.gosterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterBut.Location = new System.Drawing.Point(250, 73);
            this.gosterBut.Name = "gosterBut";
            this.gosterBut.Size = new System.Drawing.Size(75, 34);
            this.gosterBut.TabIndex = 3;
            this.gosterBut.Text = "Goster";
            this.gosterBut.UseVisualStyleBackColor = true;
            this.gosterBut.Click += new System.EventHandler(this.gosterBut_Click);
            // 
            // SifremıUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 370);
            this.Controls.Add(this.gosterBut);
            this.Controls.Add(this.gosterGrid);
            this.Controls.Add(this.sicilText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremıUnuttum";
            this.Text = "SifremıUnuttum";
            ((System.ComponentModel.ISupportInitialize)(this.gosterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sicilText;
        private System.Windows.Forms.DataGridView gosterGrid;
        private System.Windows.Forms.Button gosterBut;
    }
}