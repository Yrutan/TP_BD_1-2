﻿namespace TP1_2
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_InventaireListe = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_InventaireAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_InventaireModification = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_InventaireSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_FournisseurListe = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_FournisseurAjout = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_FournisseurModification = new System.Windows.Forms.ToolStripMenuItem();
            this.LTSMI_FournisseurSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Rapports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventaireToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.TSMI_Rapports});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(525, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LTSMI_InventaireListe,
            this.LTSMI_InventaireAjout,
            this.LTSMI_InventaireModification,
            this.LTSMI_InventaireSupprimer});
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            // 
            // LTSMI_InventaireListe
            // 
            this.LTSMI_InventaireListe.Name = "LTSMI_InventaireListe";
            this.LTSMI_InventaireListe.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_InventaireListe.Text = "Liste";
            this.LTSMI_InventaireListe.Click += new System.EventHandler(this.LTSMI_InventaireListe_Click);
            // 
            // LTSMI_InventaireAjout
            // 
            this.LTSMI_InventaireAjout.Name = "LTSMI_InventaireAjout";
            this.LTSMI_InventaireAjout.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_InventaireAjout.Text = "Ajout";
            this.LTSMI_InventaireAjout.Click += new System.EventHandler(this.LTSMI_InventaireAjout_Click);
            // 
            // LTSMI_InventaireModification
            // 
            this.LTSMI_InventaireModification.Name = "LTSMI_InventaireModification";
            this.LTSMI_InventaireModification.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_InventaireModification.Text = "Modification";
            this.LTSMI_InventaireModification.Click += new System.EventHandler(this.LTSMI_InventaireModification_Click);
            // 
            // LTSMI_InventaireSupprimer
            // 
            this.LTSMI_InventaireSupprimer.Name = "LTSMI_InventaireSupprimer";
            this.LTSMI_InventaireSupprimer.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_InventaireSupprimer.Text = "Supprimer";
            this.LTSMI_InventaireSupprimer.Click += new System.EventHandler(this.LTSMI_InventaireSupprimer_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LTSMI_FournisseurListe,
            this.LTSMI_FournisseurAjout,
            this.LTSMI_FournisseurModification,
            this.LTSMI_FournisseurSupprimer});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // LTSMI_FournisseurListe
            // 
            this.LTSMI_FournisseurListe.Name = "LTSMI_FournisseurListe";
            this.LTSMI_FournisseurListe.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_FournisseurListe.Text = "Liste";
            this.LTSMI_FournisseurListe.Click += new System.EventHandler(this.LTSMI_FournisseurListe_Click);
            // 
            // LTSMI_FournisseurAjout
            // 
            this.LTSMI_FournisseurAjout.Name = "LTSMI_FournisseurAjout";
            this.LTSMI_FournisseurAjout.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_FournisseurAjout.Text = "Ajout";
            this.LTSMI_FournisseurAjout.Click += new System.EventHandler(this.LTSMI_FournisseurAjout_Click);
            // 
            // LTSMI_FournisseurModification
            // 
            this.LTSMI_FournisseurModification.Name = "LTSMI_FournisseurModification";
            this.LTSMI_FournisseurModification.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_FournisseurModification.Text = "Modification";
            this.LTSMI_FournisseurModification.Click += new System.EventHandler(this.LTSMI_FournisseurModification_Click);
            // 
            // LTSMI_FournisseurSupprimer
            // 
            this.LTSMI_FournisseurSupprimer.Name = "LTSMI_FournisseurSupprimer";
            this.LTSMI_FournisseurSupprimer.Size = new System.Drawing.Size(142, 22);
            this.LTSMI_FournisseurSupprimer.Text = "Supprimer";
            this.LTSMI_FournisseurSupprimer.Click += new System.EventHandler(this.LTSMI_FournisseurSupprimer_Click);
            // 
            // TSMI_Rapports
            // 
            this.TSMI_Rapports.Name = "TSMI_Rapports";
            this.TSMI_Rapports.Size = new System.Drawing.Size(66, 20);
            this.TSMI_Rapports.Text = "Rapports";
            this.TSMI_Rapports.Click += new System.EventHandler(this.TSMI_Rapports_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 360);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form_Main";
            this.Text = "Nous travaillons pour vous soulager";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_InventaireListe;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_InventaireAjout;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_InventaireModification;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_InventaireSupprimer;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_FournisseurListe;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_FournisseurAjout;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_FournisseurModification;
        private System.Windows.Forms.ToolStripMenuItem LTSMI_FournisseurSupprimer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Rapports;
    }
}

