using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Models;

namespace Project.Controllers
{
    public class OppController : ApiController
    {
        BAL b = new BAL();
        [HttpGet]
        public List<opportunity> showOppList()
        {
            List<opportunity> olist = b.showOpp();
            return olist;
        }

        [HttpGet]
        public opportunity ShowoppUsingId(int Idd)
        {
            opportunity olist = b.ShowoppUsingId(Idd);
            return olist;
        }
        [HttpPut]
        public int InsertOpportunity(opportunity o)
        {
            int res = b.InserOpportunity(o.Id, o.PlanNm, o.Price, o.ConvertedBy, o.Remark);
            return res;
        }

        [HttpPut]
        public int UpdateOpportunity(opportunity o)
        {
            int res = b.UpdateOpportunity(o.Id, o.PlanNm, o.Price, o.ConvertedBy, o.Remark);
            return res;
        }
        public int DeleteOpportunity(opportunity o)
        {
            int res = b.DeleteOpportunity(o.Id);
            return res;
        }
    }
}
