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
    public partial class Form_InventaireModification : Form
    {
        DataTable dt_Fournisseur;
        DataTable dt_Inventaire;

        bool _effacer = false;

        public Form_InventaireModification()
        {
            InitializeComponent();
        }

        public Form_InventaireModification(bool effacer)
        {
            InitializeComponent();
            _effacer = effacer;
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if(_effacer)
            {
                EffacerInventaire();
            }
            else
            {
                if (IsValidValue())
                {
                    UpdateInventaire();
                }
            }
        }
        private void EffacerInventaire()
        {
            String updateQuery = "Delete from Inventaire " +
                     " WHERE IdInventaire =" + CBX_IdProduit.Text;
            SqlCommand update = new SqlCommand(updateQuery, Program._connection);
            try
            {
                update.ExecuteNonQuery();
                update.Dispose();
                MessageBox.Show("Le produit dans l'inventaire a été effacé!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void UpdateInventaire()
        {

            String updateQuery = "UPDATE INVENTAIRE SET DescriptionInventaire = '" + TBX_Description.Text + "'," +
                                 "IdFournisseur =" + CBX_Fournisseur.ValueMember + "," +
                                 " QteStock ='" + TBX_QStock.Text + "'," +
                                 " QteMinimum = '" + TBX_QMin.Text + "'," +
                                 " QteMaximum = '" + TBX_QMax.Text + "'" +
                                 " WHERE IdInventaire =" + CBX_IdProduit.Text;
            SqlCommand update = new SqlCommand(updateQuery, Program._connection);
            try
            {
                update.ExecuteNonQuery();
                update.Dispose();
                MessageBox.Show("Modification réussie!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private void ClearTextBox()
        {
            TBX_Description.Text = "";
            TBX_QStock.Text = "";
            TBX_QMin.Text = "";
            TBX_QMax.Text = "";
        }

        private bool IsValidValue()
        {
            bool isvalid = false;
            try
            {
                if (!String.IsNullOrEmpty(CBX_Fournisseur.Text)
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


        private void Form_InventaireModification_Load(object sender, EventArgs e)
        {
            if(_effacer)
            {
                CBX_Fournisseur.Enabled = false;
                TBX_Description.Enabled = false;
                TBX_QStock.Enabled = false;
                TBX_QMin.Enabled = false;
                TBX_QMax.Enabled = false;

                BTN_Accept.Text = "effacer";
            }
            fillCBX_Fournisseur();
            fillCBX_Inventaire();
        }
        private void fillCBX_Fournisseur()
        {
            dt_Fournisseur = new DataTable();
            String sqlString = "SELECT IdFournisseur, NomFournisseur, AdFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur, CourrielFournisseur FROM Fournisseur";

            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program._connection);
            commandAdapter.Fill(dt_Fournisseur);
            CBX_Fournisseur.DataSource = dt_Fournisseur;
            CBX_Fournisseur.DisplayMember = "NomFournisseur";
            CBX_Fournisseur.ValueMember = "IdFournisseur";
            CBX_Fournisseur.BindingContext = this.BindingContext;

            CBX_Fournisseur.SelectedIndex = 0;
        }

        private void fillCBX_Inventaire()
        {
            dt_Inventaire = new DataTable();
            String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum FROM Inventaire";
            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program._connection);
            commandAdapter.Fill(dt_Inventaire);

            CBX_IdProduit.DataSource = dt_Inventaire;
            CBX_IdProduit.DisplayMember = "IdInventaire";
            CBX_IdProduit.ValueMember = "IdInventaire";
            CBX_IdProduit.BindingContext = this.BindingContext;

            CBX_IdProduit.SelectedIndex = 0;
        }

        private void CBX_IdProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_IdProduit.SelectedIndex >= 0)
            {
                TBX_Description.Text = dt_Inventaire.Rows[CBX_IdProduit.SelectedIndex][1].ToString();
                CBX_Fournisseur.SelectedValue = dt_Inventaire.Rows[CBX_IdProduit.SelectedIndex][2].ToString();
                TBX_QStock.Text = dt_Inventaire.Rows[CBX_IdProduit.SelectedIndex][3].ToString();
                TBX_QMin.Text = dt_Inventaire.Rows[CBX_IdProduit.SelectedIndex][4].ToString();
                TBX_QMax.Text = dt_Inventaire.Rows[CBX_IdProduit.SelectedIndex][5].ToString();
            }
        }
    }
}
