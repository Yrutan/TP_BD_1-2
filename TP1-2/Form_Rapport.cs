using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace TP1_2
{
    public partial class Form_Rapport : Form
    {
        DataSet _dataSet;

        public Form_Rapport()
        {
            InitializeComponent();
            
            TSMI_ListeAcheter.Enabled = false;
        }


        private void showListeFournisseur()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                
                String sqlCommand = "SELECT * FROM Fournisseur";

                _dataSet = new DataSet();

                dataAdapter.SelectCommand = new SqlCommand(sqlCommand, Program._connection);
                dataAdapter.Fill(_dataSet);
                

                ReportDocument rapport = new ReportDocument();
                String path = Application.StartupPath + "\\CR_ListeFournisseur.rpt";
                rapport.Load(path);
                rapport.SetDataSource(_dataSet);
                
                CRV_Rapport.ReportSource = rapport;
                CRV_Rapport.Refresh();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void showEtiquetteFournisseur()
        {
            try
            {
                String sqlCommand = "SELECT * FROM Fournisseur";
                _dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(sqlCommand, Program._connection);
                dataAdapter.Fill(_dataSet);

                ReportDocument rapport = new ReportDocument();
                String path = Application.StartupPath + "\\CR_EtiquetteFournisseur.rpt";
                rapport.Load(path);
                rapport.SetDataSource(_dataSet);

                CRV_Rapport.ReportSource = rapport;
                CRV_Rapport.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void showProduitFournisseur()
        {
            try
            {
                String sqlCommand = "SELECT * FROM Fournisseur F INNER JOIN Inventaire I ON F.IdFournisseur = I.IdFournisseur";
                _dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(sqlCommand, Program._connection);
                dataAdapter.Fill(_dataSet);

                ReportDocument rapport = new ReportDocument();
                String path = Application.StartupPath + "\\CR_ProduitFournisseur.rpt";
                rapport.Load(path);
                rapport.SetDataSource(_dataSet);

                CRV_Rapport.ReportSource = rapport;
                CRV_Rapport.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void showProduitAcheter()
        {
            try
            {
                
                String sqlCommand = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum, QteMaximum - QteStock AS Acheter FROM Inventaire"
                    + " Where QteStock < QteMinimum";
                _dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(sqlCommand, Program._connection);
                dataAdapter.Fill(_dataSet);

                ReportDocument rapport = new ReportDocument();
                String path = Application.StartupPath + "\\CR_ProduitAcheter.rpt";
                rapport.Load(path);
                rapport.SetDataSource(_dataSet);

                CRV_Rapport.ReportSource = rapport;
                CRV_Rapport.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void TSMI_ListeFournisseur_Click(object sender, EventArgs e)
        {
            showListeFournisseur();
        }

        private void TSMI_EtiquetteFournisseur_Click(object sender, EventArgs e)
        {
            showEtiquetteFournisseur();
        }

        private void TSMI_ProduitFournisseur_Click(object sender, EventArgs e)
        {
            showProduitFournisseur();
        }

        private void TSMI_ListeAcheter_Click(object sender, EventArgs e)
        {
            showProduitAcheter();
        }

    }
}
