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
    public partial class Form_InventaireListe : Form
    {

        DataTable dataSet = new DataTable();
        public Form_InventaireListe()
        {
            InitializeComponent();
        }

        private void Form_InventaireListe_Load(object sender, EventArgs e)
        {
            selectInventaire();
        }
        private void selectInventaire()
        {
            dataSet = new DataTable();
            if (TBX_Description.Text.Length > 0)
            {
                String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum FROM Inventaire"
                + " where DescriptionInventaire LIKE '%" + TBX_Description.Text + "%'";
                SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
                commandAdapter.Fill(dataSet);
                DGV_Liste.DataSource = dataSet;
            }
            else
            {
                String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum FROM Inventaire";
                SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
                commandAdapter.Fill(dataSet);
                DGV_Liste.DataSource = dataSet;
            }
            DGV_Liste.Refresh();
        }
        private void selectInventaireToBuy()
        {
            dataSet = new DataTable();
            if (TBX_Description.Text.Length > 0)
            {
                String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum, QteMaximum - QteStock AS Acheter FROM Inventaire"
                + " where DescriptionInventaire LIKE '%" + TBX_Description.Text + "%'"
                + " and QteStock <= QteMinimum";
                SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
                commandAdapter.Fill(dataSet);
                DGV_Liste.DataSource = dataSet;
            }
            else
            {
                String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum, QteMaximum - QteStock AS Acheter FROM Inventaire"
                    + " Where QteStock <= QteMinimum";
                SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
                commandAdapter.Fill(dataSet);
                DGV_Liste.DataSource = dataSet;
            }
            DGV_Liste.Refresh();
        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
            if(CHBX_Besoin.Checked)
            {
                selectInventaireToBuy();
            }
            else
            {
                selectInventaire();
            }
        }

        private void CHBX_Besoin_CheckedChanged(object sender, EventArgs e)
        {
            if(CHBX_Besoin.Checked)
            {
                selectInventaireToBuy();
            }
            else
            {
                selectInventaire();
            }
        }
    }
}
