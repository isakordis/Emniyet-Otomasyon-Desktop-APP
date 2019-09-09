namespace Emniyet_Otomasyon
{
    partial class SorguAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorguAra));
            this.araLabel = new System.Windows.Forms.Label();
            this.araText = new System.Windows.Forms.TextBox();
            this.araBut = new System.Windows.Forms.Button();
            this.araData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.araData)).BeginInit();
            this.SuspendLayout();
            // 
            // araLabel
            // 
            this.araLabel.AutoSize = true;
            this.araLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araLabel.Location = new System.Drawing.Point(73, 90);
            this.araLabel.Name = "araLabel";
            this.araLabel.Size = new System.Drawing.Size(40, 20);
            this.araLabel.TabIndex = 0;
            this.araLabel.Text = "Ara:";
            // 
            // araText
            // 
            this.araText.Location = new System.Drawing.Point(153, 90);
            this.araText.Name = "araText";
            this.araText.Size = new System.Drawing.Size(117, 20);
            this.araText.TabIndex = 1;
            // 
            // araBut
            // 
            this.araBut.Location = new System.Drawing.Point(324, 90);
            this.araBut.Name = "araBut";
            this.araBut.Size = new System.Drawing.Size(84, 40);
            this.araBut.TabIndex = 2;
            this.araBut.Text = "Ara";
            this.araBut.UseVisualStyleBackColor = true;
            this.araBut.Click += new System.EventHandler(this.araBut_Click);
            // 
            // araData
            // 
            this.araData.AllowUserToAddRows = false;
            this.araData.AllowUserToDeleteRows = false;
            this.araData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araData.Location = new System.Drawing.Point(54, 133);
            this.araData.Name = "araData";
            this.araData.Size = new System.Drawing.Size(264, 150);
            this.araData.TabIndex = 3;
            // 
            // SorguAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 393);
            this.Controls.Add(this.araData);
            this.Controls.Add(this.araBut);
            this.Controls.Add(this.araText);
            this.Controls.Add(this.araLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorguAra";
            this.Text = "SorguAra";
            ((System.ComponentModel.ISupportInitialize)(this.araData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label araLabel;
        private System.Windows.Forms.TextBox araText;
        private System.Windows.Forms.Button araBut;
        private System.Windows.Forms.DataGridView araData;
    }
}