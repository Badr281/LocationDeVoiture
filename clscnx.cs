using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_deLocation_deVoiture
{
    class clscnx
    {
        public static SqlConnection cn = new SqlConnection();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();



        public static void connecter()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-EJN41T2\SQLEXPRESS;Database=LocationVoiture;Integrated Security=True");
            cn.Open();
        }
        public static void disconect()
        {
            cn.Close();
        }
        public static void msql(string req, string tb)
        {
            da = new SqlDataAdapter(req, cn);
            ds = new DataSet();
            dt = new DataTable();
            da.Fill(ds, "tb");
            dt = ds.Tables["tb"];
            da.Dispose();
            cn.Close();
        }


    }
}
