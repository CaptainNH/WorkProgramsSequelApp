using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProgramsSequelApp
{
    static class DataBaseWorker
    {
        public static string connectString;

        static SqlConnection connection;

        static string SQLServer = @"(localdb)\mssqllocaldb";

        static string DBName = "helloappdb";

        public static void OpenConnection()
        {
            connectString = $"Server={SQLServer};Database={DBName};Trusted_Connection = True;";
            connection = new SqlConnection(connectString);
            connection.Open();
        }

        public static DataSet ExecuteQuery(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet response = new DataSet();

            adapter.Fill(response);

            if (response.Tables.Count != 0)
                return response;
            else
                return null;
        }

        public static void ExecuteQueryWithoutResponse(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

    }
}
