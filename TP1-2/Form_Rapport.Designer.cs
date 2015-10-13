namespace TP1_2
{
    partial class Form_Rapport
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
            this.PNL_Rapport = new System.Windows.Forms.Panel();
            this.CRV_Rapport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MS_Menu = new System.Windows.Forms.MenuStrip();
            this.TSMI_ListeFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EtiquetteFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ProduitFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ListeAcheter = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_Rapport.SuspendLayout();
            this.MS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Rapport
            // 
            this.PNL_Rapport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Rapport.Controls.Add(this.CRV_Rapport);
            this.PNL_Rapport.Location = new System.Drawing.Point(12, 35);
            this.PNL_Rapport.Name = "PNL_Rapport";
            this.PNL_Rapport.Size = new System.Drawing.Size(631, 318);
            this.PNL_Rapport.TabIndex = 0;
            // 
            // CRV_Rapport
            // 
            this.CRV_Rapport.ActiveViewIndex = -1;
            this.CRV_Rapport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Rapport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Rapport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Rapport.Location = new System.Drawing.Point(0, 0);
            this.CRV_Rapport.Name = "CRV_Rapport";
            this.CRV_Rapport.Size = new System.Drawing.Size(631, 318);
            this.CRV_Rapport.TabIndex = 0;
            // 
            // MS_Menu
            // 
            this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ListeFournisseur,
            this.TSMI_EtiquetteFournisseur,
            this.TSMI_ProduitFournisseur,
            this.TSMI_ListeAcheter});
            this.MS_Menu.Location = new System.Drawing.Point(0, 0);
            this.MS_Menu.Name = "MS_Menu";
            this.MS_Menu.Size = new System.Drawing.Size(658, 24);
            this.MS_Menu.TabIndex = 1;
            this.MS_Menu.Text = "menuStrip1";
            // 
            // TSMI_ListeFournisseur
            // 
            this.TSMI_ListeFournisseur.Name = "TSMI_ListeFournisseur";
            this.TSMI_ListeFournisseur.Size = new System.Drawing.Size(133, 20);
            this.TSMI_ListeFournisseur.Text = "Liste des Fournisseurs";
            this.TSMI_ListeFournisseur.Click += new System.EventHandler(this.TSMI_ListeFournisseur_Click);
            // 
            // TSMI_EtiquetteFournisseur
            // 
            this.TSMI_EtiquetteFournisseur.Name = "TSMI_EtiquetteFournisseur";
            this.TSMI_EtiquetteFournisseur.Size = new System.Drawing.Size(146, 20);
            this.TSMI_EtiquetteFournisseur.Text = "Étiquette de Fournisseur";
            this.TSMI_EtiquetteFournisseur.Click += new System.EventHandler(this.TSMI_EtiquetteFournisseur_Click);
            // 
            // TSMI_ProduitFournisseur
            // 
            this.TSMI_ProduitFournisseur.Name = "TSMI_ProduitFournisseur";
            this.TSMI_ProduitFournisseur.Size = new System.Drawing.Size(151, 20);
            this.TSMI_ProduitFournisseur.Text = "Produits des fournisseurs";
            this.TSMI_ProduitFournisseur.Click += new System.EventHandler(this.TSMI_ProduitFournisseur_Click);
            // 
            // TSMI_ListeAcheter
            // 
            this.TSMI_ListeAcheter.Name = "TSMI_ListeAcheter";
            this.TSMI_ListeAcheter.Size = new System.Drawing.Size(162, 20);
            this.TSMI_ListeAcheter.Text = "Liste des produits à acheter";
            this.TSMI_ListeAcheter.Click += new System.EventHandler(this.TSMI_ListeAcheter_Click);
            // 
            // Form_Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 366);
            this.Controls.Add(this.PNL_Rapport);
            this.Controls.Add(this.MS_Menu);
            this.MainMenuStrip = this.MS_Menu;
            this.Name = "Form_Rapport";
            this.Text = "Form_Rapport";
            this.PNL_Rapport.ResumeLayout(false);
            this.MS_Menu.ResumeLayout(false);
            this.MS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Rapport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Rapport;
        private System.Windows.Forms.MenuStrip MS_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ListeFournisseur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EtiquetteFournisseur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ProduitFournisseur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ListeAcheter;
    }
}