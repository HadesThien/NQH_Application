﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    internal class Connection
    {
        private static SqlConnection conn;

        public static void connect()
        {
            string s = "Data Source=TRUONGNHATTHIEN;Initial Catalog=Final_SE;Integrated Security=True;";
            conn = new SqlConnection(s);
            conn.Open();
        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        
        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
    }
}
