using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace cuoiki.Utils
{
    internal class DatabaseHelper
    {
        public static String serverName;
        public static String dbName;
        public static String userDb;
        public static String password;

        public static SqlConnection getConnection()
        {
            String strCon = "server = " + serverName +
                "; Initial Catalog = " + dbName +
                "; uid = " + userDb +
                ";pwd = " + password;
            return new SqlConnection(strCon);


        }
    }
}
