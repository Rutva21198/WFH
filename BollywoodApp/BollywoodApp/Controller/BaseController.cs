using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


abstract class BaseController
{
    SqlConnection sqlConnection { get; set; }
    SqlCommand sqlCommand { get; set; }
    public void getConnection()
    {
        sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JDM9BBH\SQLEXPRESS;Initial Catalog=BollywoodDb;Integrated Security=True;");
        sqlConnection.Open();
    }
    public bool Add(string query)
    {
        sqlCommand = new SqlCommand(query, sqlConnection);
        int res = sqlCommand.ExecuteNonQuery();
        if (res > 0)
            return true;
        else
            return false;
    }
    public SqlDataReader Get(String query)
    {
        sqlCommand = new SqlCommand(query, sqlConnection);
        SqlDataReader reader = sqlCommand.ExecuteReader();
        return reader;
    }
    public bool Delete(string query)
    {
        sqlCommand = new SqlCommand(query, sqlConnection);
        int res = sqlCommand.ExecuteNonQuery();
        if (res > 0)
            return true;
        else
            return false;
    }
}

