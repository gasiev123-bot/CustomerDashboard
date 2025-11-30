using CustomerDashboard.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class TrendsController : Controller
    {
        // GET: Trends
        private readonly CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTrends()
        {
            var trends = repo.GetTrends();
            return Json(trends, JsonRequestBehavior.AllowGet);
        } 

    }
}