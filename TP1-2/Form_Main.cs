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


        private bool checkForInventaire()
        {
            bool existe = false;
            // select Inventaire


            return existe;
        }

        private bool checkForFournisseur()
        {
            bool existe = false;
            // select Fournisseur


            return existe;
        }


        private void LTSMI_InventaireListe_Click(object sender, EventArgs e)
        {
            if(checkForInventaire())
            {
                Form_InventaireListe form = new Form_InventaireListe();

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Il doit exister un item dans l'inventaire pour pouvoir afficher la liste!");
            }
        }

        private void LTSMI_InventaireAjout_Click(object sender, EventArgs e)
        {
            // vérifier si un fournisseur existe
            if(checkForFournisseur())
            {
                Form_InventaireAjout form = new Form_InventaireAjout();
                if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //code pour ajout
                    // ou dans le form ajouter ?

                }
                else
                {
                    // rien, l'opération est annulé
                }
            }
            else
            {
                MessageBox.Show("Un fournisseur doit exister pour pouvoir ajouter un item à l'inventaire!");
            }
        }

        private void LTSMI_InventaireModification_Click(object sender, EventArgs e)
        {
            if(checkForInventaire())
            {
                Form_InventaireModification form = new Form_InventaireModification();

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {   
                    //code pour update
                    // ne peut pas descendre en dessous de zéro (valeur négative)
                    // faire un trigger sur la colonne ?
                    // catch erreur du trigger et faire un popup ?
                }
            }
            else
            {
                MessageBox.Show("Il doit exister un item dans l'inventaire pour pouvoir le modifier!");
            }
        }

        private void LTSMI_FournisseurListe_Click(object sender, EventArgs e)
        {
            if(checkForFournisseur())
            {
                Form_FournisseurListe form = new Form_FournisseurListe();

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Un fournisseur doit exister pour pouvoir la liste des fournisseurs!");
            }
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
            if(checkForFournisseur())
            {
                Form_FournisseurModification form = new Form_FournisseurModification();

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //code pour update
                }
            }
            else
            {
                MessageBox.Show("Un fournisseur doit exister pour pouvoir en modifier un!");
            }
        }




    }
}
