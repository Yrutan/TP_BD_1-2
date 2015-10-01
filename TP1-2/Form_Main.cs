using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void LTSMI_InventaireListe_Click(object sender, EventArgs e)
        {
            Form_InventaireListe form = new Form_InventaireListe();

            form.ShowDialog();
        }

        private void LTSMI_InventaireAjout_Click(object sender, EventArgs e)
        {
            Form_InventaireAjout form = new Form_InventaireAjout();

            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //code pour ajout
            }
            else
            {
                // rien, l'opération est annulé
            }

        }

        private void LTSMI_InventaireModification_Click(object sender, EventArgs e)
        {
            Form_InventaireModification form = new Form_InventaireModification();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //code pour update
            }
        }

        private void LTSMI_FournisseurListe_Click(object sender, EventArgs e)
        {
            Form_FournisseurListe form = new Form_FournisseurListe();

            form.ShowDialog();
        }

        private void LTSMI_FournisseurAjout_Click(object sender, EventArgs e)
        {
            Form_FournisseurAjout form = new Form_FournisseurAjout();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //code pour ajout
            }
        }

        private void LTSMI_FournisseurModification_Click(object sender, EventArgs e)
        {
            Form_FournisseurModification form = new Form_FournisseurModification();

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //code pour update
            }
        }




    }
}
