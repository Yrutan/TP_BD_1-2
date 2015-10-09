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

        DataSet dataSet = new DataSet();
        public Form_InventaireListe()
        {
            InitializeComponent();

            String sqlString = "SELECT FROM Inventaire";
            SqlDataAdapter command = new SqlDataAdapter(sqlString, Program.connection);
            command.Fill(dataSet);

            DGV_Liste.DataSource = dataSet;
        }
    }
}
