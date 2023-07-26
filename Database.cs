using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho_Tuan1
{
    class Database
    {
        private static string strConnection = @"server=.\SQLEXPRESS;database=QuanLyKho;integrated security=true";
        public static void Execute(string strCommand, Dictionary<string, object> parameter)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(strCommand, connection);
            foreach(string key in parameter.Keys){
                command.Parameters.Add(new SqlParameter(key, parameter[key]));
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Query(string strCommand, Dictionary<string, object> parameter)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(strCommand, connection);
            foreach(string key in parameter.Keys)
            {
                command.Parameters.Add(new SqlParameter(key, parameter[key]));
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
