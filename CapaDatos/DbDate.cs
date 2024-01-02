using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    

    public class DbDate
    {
        private static DbDate con;

        // private string mensaje = "";
        private DbDate()
        {
            con = null;
        }        

        public static DbDate inf
        {
            get
            {
                if (con == null)
                {
                    con = new DbDate();
                }
                return con;
            }
        }

       
            public SqlConnection GetSqlConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDbDate"].ConnectionString;
                return new SqlConnection(connectionString);
            }
        
        
    }
}
