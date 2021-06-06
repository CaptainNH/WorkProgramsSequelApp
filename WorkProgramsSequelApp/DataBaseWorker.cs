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

        /// <summary>
        /// Подключение к базе данных.
        /// </summary>
        public static void OpenConnection()
        {
            connectString = $"Server={SQLServer};Database={DBName};Trusted_Connection = True;";
            connection = new SqlConnection(connectString);
            connection.Open();
        }

        /// <summary>
        /// Выполнение запроса и возвращение ответа.
        /// </summary>
        public static DataTable ExecuteQuery(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable response = new DataTable();

            adapter.Fill(response);

            if (response.Columns.Count != 0)
                return response;
            else
                return null;
        }

        /// <summary>
        /// Выполнение запроса без ответа.
        /// </summary>
        public static void ExecuteQueryWithoutResponse(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Закрытие соединения с БД.
        /// </summary>
        public static void CloseConnection()
        {
            connection.Close();
        }

    }
}
