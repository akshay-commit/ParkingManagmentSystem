using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ParkingApplication1.DL
{
    public class DAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        public int Insert(string sp_name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(sp_name, con);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                return i;

            }
            catch (Exception EX)
            {

                throw EX;
            }
            finally
            {

                con.Close();
            }
        }

        public DataSet GET(string sp_name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                cmd = new SqlCommand(sp_name, con);
                cmd.CommandType = CommandType.Text;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception EX)
            {

                throw EX;
            }
            finally
            {
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
            return ds;
           }
    }
}