using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class connection
    {
        public static string strcon = "Data Source=DESKTOP-OOHG6VK;Initial Catalog=Tournoi;Integrated Security=True";
        public SqlConnection sqlcon = new SqlConnection(strcon);
        //public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataSet ds = new DataSet();
    }
}
