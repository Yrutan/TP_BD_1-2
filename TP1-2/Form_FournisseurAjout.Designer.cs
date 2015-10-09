namespace TP1_2
{
    partial class Form_FournisseurAjout
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
            this.BTN_Accept = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_Adresse = new System.Windows.Forms.TextBox();
            this.TBX_Ville = new System.Windows.Forms.TextBox();
            this.TBX_CP = new System.Windows.Forms.TextBox();
            this.TBX_Telephone = new System.Windows.Forms.TextBox();
            this.TBX_Solde = new System.Windows.Forms.TextBox();
            this.TBX_Courriel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accept.Location = new System.Drawing.Point(12, 215);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accept.TabIndex = 0;
            this.BTN_Accept.Text = "Ajouter";
            this.BTN_Accept.UseVisualStyleBackColor = true;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(187, 215);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 0;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du frounisseur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse du fournisseur : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ville du fournisseur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Téléphone du fournisseur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Solde du fournisseur : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "CP du fournisseur : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Courriel du fournisseur : ";
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(153, 16);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(109, 20);
            this.TBX_Nom.TabIndex = 4;
            // 
            // TBX_Adresse
            // 
            this.TBX_Adresse.Location = new System.Drawing.Point(153, 42);
            this.TBX_Adresse.Name = "TBX_Adresse";
            this.TBX_Adresse.Size = new System.Drawing.Size(109, 20);
            this.TBX_Adresse.TabIndex = 4;
            // 
            // TBX_Ville
            // 
            this.TBX_Ville.Location = new System.Drawing.Point(153, 68);
            this.TBX_Ville.Name = "TBX_Ville";
            this.TBX_Ville.Size = new System.Drawing.Size(109, 20);
            this.TBX_Ville.TabIndex = 4;
            // 
            // TBX_CP
            // 
            this.TBX_CP.Location = new System.Drawing.Point(153, 94);
            this.TBX_CP.Name = "TBX_CP";
            this.TBX_CP.Size = new System.Drawing.Size(109, 20);
            this.TBX_CP.TabIndex = 4;
            // 
            // TBX_Telephone
            // 
            this.TBX_Telephone.Location = new System.Drawing.Point(153, 120);
            this.TBX_Telephone.Name = "TBX_Telephone";
            this.TBX_Telephone.Size = new System.Drawing.Size(109, 20);
            this.TBX_Telephone.TabIndex = 4;
            // 
            // TBX_Solde
            // 
            this.TBX_Solde.Location = new System.Drawing.Point(153, 147);
            this.TBX_Solde.Name = "TBX_Solde";
            this.TBX_Solde.Size = new System.Drawing.Size(109, 20);
            this.TBX_Solde.TabIndex = 4;
            // 
            // TBX_Courriel
            // 
            this.TBX_Courriel.Location = new System.Drawing.Point(153, 175);
            this.TBX_Courriel.Name = "TBX_Courriel";
            this.TBX_Courriel.Size = new System.Drawing.Size(109, 20);
            this.TBX_Courriel.TabIndex = 4;
            // 
            // Form_FournisseurAjout
            // 
            this.AcceptButton = this.BTN_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(281, 246);
            this.Controls.Add(this.TBX_Courriel);
            this.Controls.Add(this.TBX_Solde);
            this.Controls.Add(this.TBX_Telephone);
            this.Controls.Add(this.TBX_CP);
            this.Controls.Add(this.TBX_Ville);
            this.Controls.Add(this.TBX_Adresse);
            this.Controls.Add(this.TBX_Nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accept);
            this.Name = "Form_FournisseurAjout";
            this.Text = "Form_FournisseurAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Accept;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.TextBox TBX_Adresse;
        private System.Windows.Forms.TextBox TBX_Ville;
        private System.Windows.Forms.TextBox TBX_CP;
        private System.Windows.Forms.TextBox TBX_Telephone;
        private System.Windows.Forms.TextBox TBX_Solde;
        private System.Windows.Forms.TextBox TBX_Courriel;
    }
}