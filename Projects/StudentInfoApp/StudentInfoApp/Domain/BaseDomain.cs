using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfoApp.Domain
{
    public abstract class BaseDomain
    {
        SqlConnection sqlConnection { get; set; }
        SqlCommand sqlCommand { get; set; }
        public void getConnection()
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JDM9BBH\SQLEXPRESS;initial catalog=StudentDb;integrated security=True;");
            sqlConnection.Open();
        }
        public void ExecuteQuery(string query)
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
