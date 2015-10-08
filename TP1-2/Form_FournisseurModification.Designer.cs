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
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(187, 227);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 1;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accept.Location = new System.Drawing.Point(12, 227);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accept.TabIndex = 2;
            this.BTN_Accept.Text = "Modifier";
            this.BTN_Accept.UseVisualStyleBackColor = true;
            // 
            // Form_FournisseurModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accept);
            this.Name = "Form_FournisseurModification";
            this.Text = "Form_FournisseurModification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Accept;
    }
}