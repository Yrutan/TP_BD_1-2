using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            String sqlString = "SELECT * FROM Inventaire";
            SqlCommand command = new SqlCommand(sqlString,Program._connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int i = 0;
            while(dataReader.Read())
            {
                i++;
            }
            if(i > 0)
            {
                existe = true;
            }

            dataReader.Close();
            command.Dispose();

            return existe;
        }

        private bool checkForFournisseur()
        {
            bool existe = false;
            String sqlString = "SELECT * FROM Fournisseur";
            SqlCommand command = new SqlCommand(sqlString, Program._connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                i++;
            }
            if (i > 0)
            {
                existe = true;
            }

            dataReader.Close();
            command.Dispose();

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
            if (checkForFournisseur())
            {
                Form_InventaireAjout form = new Form_InventaireAjout();
                form.ShowDialog();
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
                form.ShowDialog();
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
            form.ShowDialog();

        }

        private void LTSMI_FournisseurModification_Click(object sender, EventArgs e)
        {
            if(checkForFournisseur())
            {
                Form_FournisseurModification form = new Form_FournisseurModification();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Un fournisseur doit exister pour pouvoir en modifier un!");
            }
        }

        private void LTSMI_FournisseurSupprimer_Click(object sender, EventArgs e)
        {
            if (checkForFournisseur())
            {
                Form_FournisseurModification form = new Form_FournisseurModification(true);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Un fournisseur doit exister pour pouvoir en effacer un!");
            }
        }

        private void LTSMI_InventaireSupprimer_Click(object sender, EventArgs e)
        {
            if (checkForInventaire())
            {
                Form_InventaireModification form = new Form_InventaireModification(true);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Il doit exister un item dans l'inventaire pour pouvoir en effacer un!");
            }
        }

        private void TSMI_Rapports_Click(object sender, EventArgs e)
        {
            Form_Rapport form = new Form_Rapport();

            form.ShowDialog();
        }
    }
}
