using CustomerDashboard.Data;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile

        private readonly CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProfile()
        {
            var profile = repo.GetProfile();  
            return Json(profile, JsonRequestBehavior.AllowGet);
        }


    }
}