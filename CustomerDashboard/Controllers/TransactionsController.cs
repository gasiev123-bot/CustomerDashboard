using CustomerDashboard.Data;
using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;

namespace CustomerDashboard.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly CustomerRepository repo = new CustomerRepository();

        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transactions/GetTransactions
        public ActionResult GetTransactions(int limit = 20, int offset = 0)
        {
            var allTransactions = repo.GetTransactions();
            var transactionsList = allTransactions.Transactions;
             
            var paged = transactionsList.Skip(offset).Take(limit).ToList();

            var response = new
            {
                transactions = paged,
                pagination = new
                {
                    total = transactionsList.Count,
                    limit,
                    offset,
                    hasMore = offset + limit < transactionsList.Count
                }
            };

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}
