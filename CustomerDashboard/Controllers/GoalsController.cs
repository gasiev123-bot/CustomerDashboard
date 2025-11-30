using CustomerDashboard.Data;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class GoalsController : Controller
    {
        // GET: Goals

        private readonly CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }

         public ActionResult GetGoals()
        {
            var goals = repo.GetGoals();
            return Json(goals, JsonRequestBehavior.AllowGet);
        }
    }
}