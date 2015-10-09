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
    public partial class Form_FournisseurModification : Form
    {
        String id;

        public Form_FournisseurModification()
        {
            InitializeComponent();
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidValue())
            {
                UpdateFournisseur(id);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Erreur Lors de l'update");
            }
        }

        private void UpdateFournisseur(String id)
        {

            String updateQuery = "UPDATE FOURNISSEUR SET NomFournisseur = '" + TBX_Nom.Text + "'," +
                                 " AdFournisseur ='" + TBX_Adresse.Text + "'," +
                                 " VilleFournisseur = '" + TBX_Ville.Text + "'," +
                                 " CPFournisseur = '" + TBX_CP.Text + "'," +
                                 " TelFournisseur =" + TBX_Telephone.Text + "," +
                                 " SoldeFournisseur = '" + TBX_Solde.Text + "' " +
                                 " CourrielFournisseur = '" + TBX_Courriel.Text + "' " +
                                 " WHERE IdFournisseur =" + id;
            MessageBox.Show(updateQuery);
            SqlCommand update = new SqlCommand(updateQuery, Program.connection);
            try
            {
                update.ExecuteNonQuery();
                update.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        private void ClearTextBox()
        {
            TBX_Nom.Text = "";
            TBX_Adresse.Text = "";
            TBX_Ville.Text = "";
            TBX_CP.Text = "";
            TBX_Telephone.Text = "";
            TBX_Solde.Text = "";
            TBX_Courriel.Text = "";
        }

        private bool IsValidValue()
        {
            bool isvalid = false;
            try
            {
                if (!String.IsNullOrEmpty(TBX_Adresse.Text)
                    && !String.IsNullOrEmpty(TBX_CP.Text)
                    && !String.IsNullOrEmpty(TBX_Solde.Text)
                    && !String.IsNullOrEmpty(TBX_Telephone.Text)
                    && !String.IsNullOrEmpty(TBX_Ville.Text)
                    && !String.IsNullOrEmpty(TBX_Nom.Text)
                    && !String.IsNullOrEmpty(TBX_Courriel.Text)
                    && Int32.Parse(TBX_Solde.Text) >= 0)
                {

                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("Valeur non valide");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de solde");
                isvalid = false;
            }
            return isvalid;
        }
    }
}
