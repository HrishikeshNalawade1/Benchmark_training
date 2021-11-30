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
             
              cmd.Parameters.AddWithValue("DoB", DoB);
              cmd.Parameters.AddWithValue("Remark", Remark);
              cmd.ExecuteNonQuery();
              return true;
        }
       

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
