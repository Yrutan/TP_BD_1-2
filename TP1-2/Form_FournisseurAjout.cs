using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1_2
{
    public partial class Form_FournisseurAjout : Form
    {
        public Form_FournisseurAjout()
        {
            InitializeComponent();
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidValue())
            {
                Ajouter(TBX_Nom.Text, TBX_Adresse.Text, TBX_Ville.Text, TBX_CP.Text, TBX_Telephone.Text, TBX_Solde.Text, TBX_Courriel.Text);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Valeur entrée invalide");
            }
        }

        private void Ajouter(String nom, String adresse, String ville, String codep, String tel, String solde, String courriel)
        {
            String sqlInsert = "INSERT INTO FOURNISSEUR(NomFournisseur, AdFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur, CourrielFournisseur) " +
                   "VALUES('" + nom + "', ' " + adresse + "', ' " + ville + "','" + codep + "', ' " + tel + "'," + solde + ", ' " + courriel + "')";

            SqlCommand insert = new SqlCommand(sqlInsert);
            insert.Connection = Program.connection;

            if (insert.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Ajout du fournisseur réussie");
            }
            else
            {
                MessageBox.Show("Erreur durant l'ajout");
            }

            insert.Dispose();
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
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de solde");
                isvalid = false;
            }
            return isvalid;
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
