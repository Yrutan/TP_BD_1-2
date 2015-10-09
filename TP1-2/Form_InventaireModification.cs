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
    public partial class Form_InventaireModification : Form
    {
        public Form_InventaireModification()
        {
            InitializeComponent();
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {

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
            TBX_Description.Text = "";
            CBX_Fournisseur.Text = "";
            TBX_QStock.Text = "";
            TBX_QMin.Text = "";
            TBX_QMax.Text = "";
        }

        private bool IsValidValue()
        {
            bool isvalid = false;
            try
            {
                if (!String.IsNullOrEmpty(TBX_Description.Text)
                    && !String.IsNullOrEmpty(CBX_Fournisseur.Text)
                    && !String.IsNullOrEmpty(TBX_QStock.Text)
                    && !String.IsNullOrEmpty(TBX_QMin.Text)
                    && !String.IsNullOrEmpty(TBX_QMax.Text))
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
                MessageBox.Show(e.ToString());
                isvalid = false;
            }
            return isvalid;
        }
    }
}
