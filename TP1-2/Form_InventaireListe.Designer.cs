namespace TP1_2
{
    partial class Form_InventaireListe
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
            this.CHBX_Besoin = new System.Windows.Forms.CheckBox();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Liste
            // 
            this.DGV_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste.Location = new System.Drawing.Point(12, 42);
            this.DGV_Liste.Name = "DGV_Liste";
            this.DGV_Liste.Size = new System.Drawing.Size(756, 245);
            this.DGV_Liste.TabIndex = 1;
            // 
            // CHBX_Besoin
            // 
            this.CHBX_Besoin.AutoSize = true;
            this.CHBX_Besoin.Location = new System.Drawing.Point(637, 16);
            this.CHBX_Besoin.Name = "CHBX_Besoin";
            this.CHBX_Besoin.Size = new System.Drawing.Size(131, 17);
            this.CHBX_Besoin.TabIndex = 2;
            this.CHBX_Besoin.Text = "Besoin de commander";
            this.CHBX_Besoin.UseVisualStyleBackColor = true;
            this.CHBX_Besoin.CheckedChanged += new System.EventHandler(this.CHBX_Besoin_CheckedChanged);
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(84, 13);
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(158, 20);
            this.TBX_Description.TabIndex = 3;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description : ";
            // 
            // Form_InventaireListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.CHBX_Besoin);
            this.Controls.Add(this.DGV_Liste);
            this.Name = "Form_InventaireListe";
            this.Text = "Liste de l\'inventaire";
            this.Load += new System.EventHandler(this.Form_InventaireListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Liste;
        private System.Windows.Forms.CheckBox CHBX_Besoin;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.Label label1;
    }
}