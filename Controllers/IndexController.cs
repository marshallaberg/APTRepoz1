using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APTravel.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
    }

    public class CustomOriginHeader : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PreSendRequestHeaders += OnPreSendRequestHeaders;
        }

        public void Dispose() { }

        void OnPreSendRequestHeaders(object sender, EventArgs e)
        {
            // For example - To add header only for JS files
            if (HttpContext.Current.Request.Url.ToString().Contains("sygic"))
            {
                HttpContext.Current.Response.Headers.Add("x-api-key", "q0jgvuoQPZ6S1DWLWOYkPMjHGkU7Yfu3z3PsJt76");
            }
        }
    }
}