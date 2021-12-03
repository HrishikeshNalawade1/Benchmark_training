using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Api_consumer.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44340/api/Demo");
                var result = client.GetAsync("Demo");
                result.Wait();
                var res = result.Result;
               
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof (List<string>));
                    {
                        data.Wait();
                        List<string>  s = data.Result as List<string>;
                        SelectListItem itemlist = new SelectListItem();
                        foreach (string dt in s)
                        {
                            itemlist.Text = dt;
                            itemlist.Value = dt;
                            itemlist.Add(new SelectListItem() { Text = dt, Value = dt }) ;
                        }
                        ViewData["response"] = s;

                    }
                }
                else
                {
                    ViewData["response"] = "Error Calling";
                }
                }

                return View();
            }
        }
       
    }
}
