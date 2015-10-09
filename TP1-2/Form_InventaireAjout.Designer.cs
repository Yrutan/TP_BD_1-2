namespace TP1_2
{
    partial class Form_InventaireAjout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.TBX_QStock = new System.Windows.Forms.TextBox();
            this.TBX_QMin = new System.Windows.Forms.TextBox();
            this.TBX_QMax = new System.Windows.Forms.TextBox();
            this.CBX_Fournisseur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(155, 179);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 1;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accept.Location = new System.Drawing.Point(12, 179);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accept.TabIndex = 2;
            this.BTN_Accept.Text = "Ajouter";
            this.BTN_Accept.UseVisualStyleBackColor = true;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description du produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fournisseur : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantité en stock : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantité minimale : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantité maximal : ";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(130, 6);
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(100, 20);
            this.TBX_Description.TabIndex = 4;
            // 
            // TBX_QStock
            // 
            this.TBX_QStock.Location = new System.Drawing.Point(130, 69);
            this.TBX_QStock.Name = "TBX_QStock";
            this.TBX_QStock.Size = new System.Drawing.Size(100, 20);
            this.TBX_QStock.TabIndex = 4;
            // 
            // TBX_QMin
            // 
            this.TBX_QMin.Location = new System.Drawing.Point(130, 98);
            this.TBX_QMin.Name = "TBX_QMin";
            this.TBX_QMin.Size = new System.Drawing.Size(100, 20);
            this.TBX_QMin.TabIndex = 4;
            // 
            // TBX_QMax
            // 
            this.TBX_QMax.Location = new System.Drawing.Point(130, 127);
            this.TBX_QMax.Name = "TBX_QMax";
            this.TBX_QMax.Size = new System.Drawing.Size(100, 20);
            this.TBX_QMax.TabIndex = 4;
            // 
            // CBX_Fournisseur
            // 
            this.CBX_Fournisseur.FormattingEnabled = true;
            this.CBX_Fournisseur.Location = new System.Drawing.Point(130, 35);
            this.CBX_Fournisseur.Name = "CBX_Fournisseur";
            this.CBX_Fournisseur.Size = new System.Drawing.Size(100, 21);
            this.CBX_Fournisseur.TabIndex = 5;
            // 
            // Form_InventaireAjout
            // 
            this.AcceptButton = this.BTN_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(249, 214);
            this.Controls.Add(this.CBX_Fournisseur);
            this.Controls.Add(this.TBX_QMax);
            this.Controls.Add(this.TBX_QMin);
            this.Controls.Add(this.TBX_QStock);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accept);
            this.Name = "Form_InventaireAjout";
            this.Text = "Form_InventaireAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.TextBox TBX_QStock;
        private System.Windows.Forms.TextBox TBX_QMin;
        private System.Windows.Forms.TextBox TBX_QMax;
        private System.Windows.Forms.ComboBox CBX_Fournisseur;
    }
}