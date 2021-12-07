using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project;
using Project.Models;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    public class BAL
    {
        DAL D = new DAL();
        public List<opportunity> showOpp()
        {
            SqlDataReader reader = D.showOpp();
            List<opportunity> olist = new List<opportunity>();
            while(reader.Read())
            {
                opportunity obj = new opportunity();
                obj.Id = Convert.ToInt32(reader["Id"].ToString());
                obj.PlanNm = (reader["PlanNm"].ToString());
                obj.Price = Convert.ToInt32(reader["Price"].ToString());
                obj.ConvertedBy = Convert.ToInt32(reader["ConvertedBy"].ToString());
                obj.Remark = (reader["Remark"].ToString());

                olist.Add(obj);
            }
            return olist;
        }

        public opportunity ShowoppUsingId(int Id)
        {
            SqlDataReader reader = D.ShowoppUsingId(Id);

            reader.Read();
            {
                opportunity obj = new opportunity();
                obj.Id = Convert.ToInt32(reader["Id"].ToString());
                obj.PlanNm = (reader["PlanNm"].ToString());
                obj.Price = Convert.ToInt32(reader["Price"].ToString());
                obj.ConvertedBy = Convert.ToInt32(reader["ConvertedBy"].ToString());
                obj.Remark = (reader["Remark"].ToString());

                return obj;
            }
        }
        public int InserOpportunity(int Idd,string PlN,int Prce,int Converted,string Rmrk)
        {
            try
            {
                opportunity o = new opportunity() { Id = Idd, PlanNm = PlN, ConvertedBy = Converted, Remark = Rmrk };
                D.InsertOpportunity(o);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public int UpdateOpportunity(int Idd, string PlN, int Prce, int Converted, string Rmrk)
        {
            try
            {
                opportunity o = new opportunity() { Id = Idd, PlanNm = PlN, ConvertedBy = Converted, Remark = Rmrk };
                D.UpdateOpportunity(o);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteOpportunity(int Idd)
        {
            try
            {
                
                D.DeleteOpportunity(Idd);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}