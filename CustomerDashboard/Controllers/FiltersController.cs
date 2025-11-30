using CustomerDashboard.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class FiltersController : Controller
    {
        // GET: Filters
        private readonly CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFilters()
        { 
            var filters = repo.GetFilters();
            return Json(filters, JsonRequestBehavior.AllowGet);
        }
    }
}