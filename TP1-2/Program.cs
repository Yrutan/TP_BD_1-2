using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP1_2
{
    static class Program
    {
        //l'objet connection utilisé partout dans l'application
        //pourrait être modifié pour une fonction avec une valeur de retour qui retourne la connection
        public static SqlConnection connection;


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //les valeurs sont celles par défaut de l'exemple
            // datasource est le chemin à la bd ?
            String dataSource = System.Environment.MachineName +"\\SQLEXPRESS2012";
            // initial Catalog est le nom de la bd
            String nameBD = "bdOperation";
            // user ID est le nom utiliser pour la connection à la bd
            String userId = "conOperation";
            // password est le mot de passe du user ID pour se connecter à la bd
            String pass = "conOperation";

            String chaineConnection = "Data Source="+dataSource+";Initial Catalog="+nameBD+";User ID="+ userId +";Password=" + pass;
            connection = new SqlConnection(chaineConnection);
 
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // code de base pour un projet en c#
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }
    }
}
