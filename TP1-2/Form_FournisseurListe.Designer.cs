namespace TP1_2
{
    partial class Form_FournisseurListe
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
            this.DGV_Liste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Liste
            // 
            this.DGV_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste.Location = new System.Drawing.Point(12, 12);
            this.DGV_Liste.Name = "DGV_Liste";
            this.DGV_Liste.Size = new System.Drawing.Size(587, 321);
            this.DGV_Liste.TabIndex = 0;
            // 
            // Form_FournisseurListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 345);
            this.Controls.Add(this.DGV_Liste);
            this.Name = "Form_FournisseurListe";
            this.Text = "Form_Fournisseur";
            this.Load += new System.EventHandler(this.Form_FournisseurListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Liste;
    }
}