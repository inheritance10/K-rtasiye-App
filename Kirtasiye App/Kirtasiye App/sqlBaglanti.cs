using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Kirtasiye_App
{
    class sqlBaglanti
    {
        public SqlConnection sqlConnection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=ALI\SQLSERVER;Initial Catalog=kirtasiyeDB;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
