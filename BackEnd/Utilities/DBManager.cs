using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace BackEnd.Utilities
{
    class DBManager
    {

        private SqlConnection conn;
        private SqlCommand cmd;

        private string server;
        private string database;

        private string connectionString;

        public DBManager()
        {
            server = @".\SQLEXPRESS";
            database = "CreateWebsite";

            connectionString = "Data Source=" + server + ";Database="+database+";Integrated Security=True" ;
        }

        public DataTable getDataFromDatabase(string dbTable)
        {
            DataTable table = new DataTable();

            try
            {
                SqlDataReader dataReader;

                using (conn = new SqlConnection(connectionString))
                using (cmd = new SqlCommand("select * from "+ dbTable + "", conn))
                {
                    conn.Open();
                    cmd.CommandTimeout = 60;

                    dataReader = cmd.ExecuteReader();
                    table.Load(dataReader);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return table;
        }
    }
}
