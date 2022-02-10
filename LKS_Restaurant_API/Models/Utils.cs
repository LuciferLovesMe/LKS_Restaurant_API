using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LKS_Restaurant_API.Models
{
    public class Utils
    {
        public static string conn = @"Data Source=desktop-00eposj;Initial Catalog=LKS_Restaurant;Integrated Security=True";
    }

    public class LoginModel
    {
        public int id { set; get; }
        public string email { set; get; }
        public string handPhone { set; get; }
        public string name { set; get; }
    }

    public class View
    {
        public int memberId { set; get; }
    }

    public class Command
    {
        public static DataTable data(string com)
        {
            SqlConnection connection = new SqlConnection(Utils.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}