using CustomerDashboard.Data;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        private readonly CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSummary()
        { 
            var summary = repo.GetSummary();             
            return Json(summary, JsonRequestBehavior.AllowGet);
        }
 

    }
}