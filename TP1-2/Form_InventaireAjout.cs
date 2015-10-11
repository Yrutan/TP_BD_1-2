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
    public partial class Form_InventaireAjout : Form
    {
        DataTable dt_Fournisseur = new DataTable();
        public Form_InventaireAjout()
        {
            InitializeComponent();
            fillCBX_Fournisseur();
        }


        private void fillCBX_Fournisseur()
        {
            String sqlString = "SELECT IdFournisseur, NomFournisseur FROM Fournisseur";
            
            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
            commandAdapter.Fill(dt_Fournisseur);
            CBX_Fournisseur.DataSource = dt_Fournisseur;
            CBX_Fournisseur.DisplayMember = "NomFournisseur";
            CBX_Fournisseur.ValueMember = "IdFournisseur";
            CBX_Fournisseur.BindingContext = this.BindingContext;

        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidValue())
            {
                Ajouter(TBX_Description.Text, CBX_Fournisseur.SelectedValue.ToString() , TBX_QStock.Text, TBX_QMin.Text, TBX_QMax.Text);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Valeur entrée invalide");
            }
        }

        private void Ajouter(String desc, String id, String qtestock, String qteminimum, String qtemaximum)
        {
            String sqlInsert = "INSERT INTO INVENTAIRE(DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum) " +
                   "VALUES('" + desc + "', ' " + id + "', ' " + qtestock + "','" + qteminimum + "', ' " + qtemaximum + "')";

            SqlCommand insert = new SqlCommand(sqlInsert);
            insert.Connection = Program.connection;

            if (insert.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("Ajout dans l'inventaire réussite");
            }
            else
            {
                MessageBox.Show("Erreur durant l'ajout");
            }

            insert.Dispose();
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
