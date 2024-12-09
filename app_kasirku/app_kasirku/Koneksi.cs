using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace app_kasirku
{
    internal class Koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=LAPTOP-U9I4MN76\\SQLEXPRESS;initial catalog=DB_APPKASIRKU; integrated security=true";
            return Conn;
        }

    }
}