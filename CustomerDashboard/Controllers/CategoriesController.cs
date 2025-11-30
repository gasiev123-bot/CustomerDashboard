using CustomerDashboard.Data;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CustomerRepository repo = new CustomerRepository();

        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategories()
        {
            var categoriesData = repo.GetCategories(); 
            return Json(categoriesData, JsonRequestBehavior.AllowGet);
        }
    }
}
