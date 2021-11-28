using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    SqlConnection con = null;
    
    public DAL()
    {
        con = new SqlConnection("Server=.;database=Register;Trusted_connection=true");
        con.Open();
    }
   
   /* Fname varchar(20),Lname varchar(25),Uname varchar(10),Paswrd varchar(10),
Adres varchar(200),Stat varchar(10),Mobil int,DoB varchar(10),Remark varchar(100),*/
    public bool Insert(string Fname,string Lname, string Uname,string Paswrd,string Adres,string Stat, string DoB,string Remark)
    {
          try
          {
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = con;
              cmd.CommandText = "InsrtInfo";
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("Fname", Fname);
              cmd.Parameters.AddWithValue("Lname", Lname);
              cmd.Parameters.AddWithValue("Uname", Uname);
              cmd.Parameters.AddWithValue("Paswrd", Paswrd);
              cmd.Parameters.AddWithValue("Adres", Adres);
              cmd.Parameters.AddWithValue("Stat", Stat);
              //cmd.Parameters.AddWithValue("Mobil", Mobil);
              cmd.Parameters.AddWithValue("DoB", DoB);
              cmd.Parameters.AddWithValue("Remark", Remark);
              cmd.ExecuteNonQuery();
              return true;
          }

        /*try
        {
            //create a connection
            con = new SqlConnection();
            con.ConnectionString = "Server=.;database=Register;trusted_connection=true";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            //create a command or pass Stored Procedure
            cmd = new SqlCommand("InsrtInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("Fname", Fname);
            SqlParameter param2 = new SqlParameter("Lname", Lname);
            SqlParameter param3 = new SqlParameter("Uname", Uname);
            SqlParameter param4 = new SqlParameter("Paswrd", Paswrd);
            SqlParameter param5 = new SqlParameter("Adres", Adres);
            SqlParameter param6 = new SqlParameter("Stat", Stat);
            SqlParameter param7 = new SqlParameter("DoB", DoB);
            SqlParameter param8 = new SqlParameter("Remark", Remark);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);
            cmd.Parameters.Add(param8);
            cmd.ExecuteNonQuery();
            return true;
        }*/


        catch (Exception )
        {
            return false;
        }
    }
    ~DAL()
    {
        con.Close();
    }

}