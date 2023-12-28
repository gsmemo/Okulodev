using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper
    {

        SqlConnection cn;
        SqlCommand cmd;
        string memo = ConfigurationManager.ConnectionStrings["memo"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection("memo"))
            {

            }
            using (cmd = new SqlCommand(cmdtext, cn))
            {
                if (p != null)
                {

                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
    

