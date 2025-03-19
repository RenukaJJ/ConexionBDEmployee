using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBDEmployee
{
    class DBConnection
    {
        
        private SqlConnection myConnection;
        string connectionString = "Data Source=46.183.117.154,54321;Initial Catalog=RenukaEmployees;User ID=sa;Password=Sql#123456789;";
        
        public DBConnection()
        {
            myConnection = new SqlConnection(connectionString);

        }

        public void AbrirConexion() { this.myConnection.Open(); }
        public void CerarConexion() { this.myConnection.Close(); }

        public SqlCommand GetCommand(string query) 
        {
            SqlCommand command = new SqlCommand(query, this.myConnection);
            return command; 
        }
    }
}
