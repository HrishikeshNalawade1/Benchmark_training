using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DALcs
/// </summary>
public class DAL
{
    SqlConnection con = null;
    public DAL()
    {
        con = new SqlConnection("Server=.;database=Company;Trusted_connection=true");
        con.Open();
    }
    public bool LoginId(string uname, string pass)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "LoginProc";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("user", uname);
            SqlParameter p2 = new SqlParameter("pwd", pass);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (SqlException)
        {
            return false;
        }
    }
        ~DAL()
        {
            con.Close();
        }
    
}
        
    

