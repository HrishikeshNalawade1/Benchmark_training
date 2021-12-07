using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Project
{
    public class DAL
    {
        public SqlDataReader showOpp()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Cons"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("showOpp",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            
        }
        public SqlDataReader ShowoppUsingId(int Id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Cons"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("ShowoppUsingId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public void InsertOpportunity(opportunity o)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Cons"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", o.Id);
            cmd.Parameters.AddWithValue("PlanNm",o.PlanNm);
            cmd.Parameters.AddWithValue("Price", o.Price);
            cmd.Parameters.AddWithValue("ConvertedBy",o.ConvertedBy);
            cmd.Parameters.AddWithValue("Remark", o.Remark);

            cmd.ExecuteNonQuery();
            
        }
        public void UpdateOpportunity(opportunity o)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Cons"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", o.Id);
            cmd.Parameters.AddWithValue("PlanNm", o.PlanNm);
            cmd.Parameters.AddWithValue("Price", o.Price);
            cmd.Parameters.AddWithValue("ConvertedBy", o.ConvertedBy);
            cmd.Parameters.AddWithValue("Remark", o.Remark);

            cmd.ExecuteNonQuery();

        }
        public void DeleteOpportunity(int Id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Cons"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteOpportunity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id", Id);
            

            cmd.ExecuteNonQuery();

        }
    }
}