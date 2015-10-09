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
            String sqlString = "SELECT IdInventaire, DescriptionInventaire, IdFournisseur, QteStock, QteMinimum, QteMaximum FROM Inventaire";
            
            SqlDataAdapter commandAdapter = new SqlDataAdapter(sqlString, Program.connection);
            commandAdapter.Fill(dataSet);
            DGV_Liste.DataSource = dataSet;
        }
    }
}
