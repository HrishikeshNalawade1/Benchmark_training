using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class opportunity
    {
        public int Id { get; set; }
        public string PlanNm { get; set; }
        public int Price { get; set; }
        public int ConvertedBy { get; set; }
        public string Remark { get; set; }
        
    }
}