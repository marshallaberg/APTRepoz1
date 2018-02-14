using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using APTravel.Models;
using IdentitySample.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace APTravel.Controllers
{

    public class TestingController : Controller
    {
        private UserManageModel UMan = new UserManageModel();

        // GET: Testing
        public ActionResult Index()
        {

            UMan.AddUser("test", "test", "test@test.com", "Tester", "McTesterSon");

            return View();
        }
    }
}