using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Utils
{
    internal class DatabaseHelper
    {
        public static String serverName;
        public static String dbName;
        public static String userDb;
        public static String password;

        public static SqlConnection GetConnection()
        {
            String strCnn = "server =" + serverName +
                "; Initial Catalog = " + dbName +
                "; uid = " + userDb +
                "; pwd = " + password;
            return new SqlConnection (strCnn);
        }
    }
}
