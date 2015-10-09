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
        public Form_InventaireAjout()
        {
            InitializeComponent();
            fillCBX_Fournisseur();
        }


        private void fillCBX_Fournisseur()
        {

        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if (IsValidValue())
            {
                Ajouter(TBX_Description.Text, CBX_Fournisseur.Text, TBX_QStock.Text, TBX_QMin.Text, TBX_QMax.Text);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Erreur durant l'ajout");
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
