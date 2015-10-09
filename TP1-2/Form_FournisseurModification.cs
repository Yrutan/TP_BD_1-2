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

        DataTable dt_Fournisseur = new DataTable();

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

            String updateQuery = "UPDATE FOURNISSEUR SET NomFournisseur = '" + CBX_Fournisseur.SelectedText + "'," +
                                 " AdFournisseur ='" + TBX_Adresse.Text + "'," +
                                 " VilleFournisseur = '" + TBX_Ville.Text + "'," +
                                 " CPFournisseur = '" + TBX_CP.Text + "'," +
                                 " TelFournisseur =" + TBX_Telephone.Text + "," +
                                 " SoldeFournisseur = '" + TBX_Solde.Text + "' " +
                                 " CourrielFournisseur = '" + TBX_Courriel.Text + "' " +
                                 " WHERE IdFournisseur =" + CBX_Fournisseur.SelectedValue;
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

        private void Form_FournisseurModification_Load(object sender, EventArgs e)
        {
            fillCBX_Fournisseur();
        }
        private void fillCBX_Fournisseur()
        {
            String sqlString = "SELECT IdFournisseur, NomFournisseur, AdFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur, CourrielFournisseur FROM Fournisseur";

            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
            commandAdapter.Fill(dt_Fournisseur);
            CBX_Fournisseur.DataSource = dt_Fournisseur;
            CBX_Fournisseur.DisplayMember = "NomFournisseur";
            CBX_Fournisseur.ValueMember = "IdFournisseur";
            CBX_Fournisseur.BindingContext = this.BindingContext;

            CBX_Fournisseur.SelectedIndex = 0;
        }

        private void CBX_Fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBX_Fournisseur.SelectedIndex > 0)
            {
                TBX_Adresse.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][2].ToString();
                TBX_Ville.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][3].ToString();
                TBX_CP.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][4].ToString();
                TBX_Telephone.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][5].ToString();
                TBX_Solde.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][6].ToString();
                TBX_Courriel.Text = dt_Fournisseur.Rows[CBX_Fournisseur.SelectedIndex][7].ToString();
            }
        }
    }
}
