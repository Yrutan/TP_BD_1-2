namespace TP1_2
{
    partial class Form_FournisseurModification
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
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Accept = new System.Windows.Forms.Button();
            this.TBX_Courriel = new System.Windows.Forms.TextBox();
            this.TBX_Solde = new System.Windows.Forms.TextBox();
            this.TBX_Telephone = new System.Windows.Forms.TextBox();
            this.TBX_CP = new System.Windows.Forms.TextBox();
            this.TBX_Ville = new System.Windows.Forms.TextBox();
            this.TBX_Adresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBX_Fournisseur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(187, 201);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 1;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accept.Location = new System.Drawing.Point(15, 201);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accept.TabIndex = 2;
            this.BTN_Accept.Text = "Modifier";
            this.BTN_Accept.UseVisualStyleBackColor = true;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // TBX_Courriel
            // 
            this.TBX_Courriel.Location = new System.Drawing.Point(153, 166);
            this.TBX_Courriel.Name = "TBX_Courriel";
            this.TBX_Courriel.Size = new System.Drawing.Size(109, 20);
            this.TBX_Courriel.TabIndex = 12;
            // 
            // TBX_Solde
            // 
            this.TBX_Solde.Location = new System.Drawing.Point(153, 138);
            this.TBX_Solde.Name = "TBX_Solde";
            this.TBX_Solde.Size = new System.Drawing.Size(109, 20);
            this.TBX_Solde.TabIndex = 13;
            // 
            // TBX_Telephone
            // 
            this.TBX_Telephone.Location = new System.Drawing.Point(153, 111);
            this.TBX_Telephone.Name = "TBX_Telephone";
            this.TBX_Telephone.Size = new System.Drawing.Size(109, 20);
            this.TBX_Telephone.TabIndex = 14;
            // 
            // TBX_CP
            // 
            this.TBX_CP.Location = new System.Drawing.Point(153, 85);
            this.TBX_CP.Name = "TBX_CP";
            this.TBX_CP.Size = new System.Drawing.Size(109, 20);
            this.TBX_CP.TabIndex = 15;
            // 
            // TBX_Ville
            // 
            this.TBX_Ville.Location = new System.Drawing.Point(153, 59);
            this.TBX_Ville.Name = "TBX_Ville";
            this.TBX_Ville.Size = new System.Drawing.Size(109, 20);
            this.TBX_Ville.TabIndex = 16;
            // 
            // TBX_Adresse
            // 
            this.TBX_Adresse.Location = new System.Drawing.Point(153, 33);
            this.TBX_Adresse.Name = "TBX_Adresse";
            this.TBX_Adresse.Size = new System.Drawing.Size(109, 20);
            this.TBX_Adresse.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CP du fournisseur : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Courriel du fournisseur : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Solde du fournisseur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone du fournisseur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville du fournisseur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adresse du fournisseur : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom du fournisseur : ";
            // 
            // CBX_Fournisseur
            // 
            this.CBX_Fournisseur.FormattingEnabled = true;
            this.CBX_Fournisseur.Location = new System.Drawing.Point(153, 6);
            this.CBX_Fournisseur.Name = "CBX_Fournisseur";
            this.CBX_Fournisseur.Size = new System.Drawing.Size(109, 21);
            this.CBX_Fournisseur.TabIndex = 19;
            this.CBX_Fournisseur.SelectedIndexChanged += new System.EventHandler(this.CBX_Fournisseur_SelectedIndexChanged);
            // 
            // Form_FournisseurModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.CBX_Fournisseur);
            this.Controls.Add(this.TBX_Courriel);
            this.Controls.Add(this.TBX_Solde);
            this.Controls.Add(this.TBX_Telephone);
            this.Controls.Add(this.TBX_CP);
            this.Controls.Add(this.TBX_Ville);
            this.Controls.Add(this.TBX_Adresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accept);
            this.Name = "Form_FournisseurModification";
            this.Text = "Form_FournisseurModification";
            this.Load += new System.EventHandler(this.Form_FournisseurModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Accept;
        private System.Windows.Forms.TextBox TBX_Courriel;
        private System.Windows.Forms.TextBox TBX_Solde;
        private System.Windows.Forms.TextBox TBX_Telephone;
        private System.Windows.Forms.TextBox TBX_CP;
        private System.Windows.Forms.TextBox TBX_Ville;
        private System.Windows.Forms.TextBox TBX_Adresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_Fournisseur;
    }
}