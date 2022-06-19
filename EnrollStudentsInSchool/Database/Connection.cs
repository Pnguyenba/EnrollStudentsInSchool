using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace EnrollStudentsInSchool_
{ 
    public class Connection
    {
        static string strDataSource = @"DESKTOP-P409H74";
        static string strDataBase = "quanlysinhvien";
        private static string strConnection = @"Data Source='" + strDataSource + "';Initial Catalog='" + strDataBase + "';Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}
