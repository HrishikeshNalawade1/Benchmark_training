using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class DemoController : ApiController
    {
       public string get()
        {
            return "Welcome to Web Api";
        }
      
        /*public List<string> get()
        {
            List<string> datalist = new List<string>();
            datalist.Add("Data1");
            datalist.Add("Data1");
            return datalist;
        }*/
        
    }
}
