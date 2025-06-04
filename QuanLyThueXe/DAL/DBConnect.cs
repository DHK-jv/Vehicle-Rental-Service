using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.DAL
{
    public class DBConnect
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;

        public DBConnect()
        {
            string strCnn = "Data source= KhangJV\\SQLEXPRESS; Database= QuanLyThueXe; Integrated Security = True";
            sqlConn = new SqlConnection(strCnn);
        }
        

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        public object ExecuteScalar(string sqlStr)
        {
            SqlCommand sqlcmd = new SqlCommand(sqlStr, sqlConn);
            sqlConn.Open();
            object result = sqlcmd.ExecuteScalar();
            sqlConn.Close();
            return result;
        }

    }
}
