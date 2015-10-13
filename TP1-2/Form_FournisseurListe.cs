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
    public partial class Form_FournisseurListe : Form
    {
        DataTable dataSet = new DataTable();
        public Form_FournisseurListe()
        {
            InitializeComponent();

        }

        private void Form_FournisseurListe_Load(object sender, EventArgs e)
        {
            String sqlString = "SELECT IdFournisseur, NomFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur FROM Fournisseur";
            
            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program._connection);
            commandAdapter.Fill(dataSet);
            DGV_Liste.DataSource = dataSet;
        }
    }
}
