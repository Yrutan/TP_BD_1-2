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
        DataSet dataSet = new DataSet();
        public Form_FournisseurListe()
        {
            InitializeComponent();

            String sqlString = "SELECT IdFournisseur, NomFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur, FROM Fournisseur";
            SqlDataAdapter command = new SqlDataAdapter(sqlString, Program.connection);
            command.Fill(dataSet);

            DGV_Liste.DataSource = dataSet;
        }
    }
}
