using Newtonsoft.Json;
using System.IO;
using System.Web.Hosting;
using CustomerDashboard.Models;

namespace CustomerDashboard.Data
{
    public class CustomerRepository
    {
        private T Load<T>(string fileName)
        {
            var path = HostingEnvironment.MapPath("~/App_Data/mockdata/" + fileName);
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public CustomerProfile GetProfile()
            => Load<CustomerProfile>("profile.json");

        public SpendingSummary GetSummary()
            => Load<SpendingSummary>("summary.json");

        public SpendingByCategory GetCategories()
            => Load<SpendingByCategory>("categories.json");

        public TransactionsResponse GetTransactions()
            => Load<TransactionsResponse>("transactions.json");

        public SpendingTrends GetTrends()
            => Load<SpendingTrends>("trends.json");

        public GoalsResponse GetGoals()
            => Load<GoalsResponse>("goals.json");

        public FiltersResponse GetFilters()
            => Load<FiltersResponse>("filters.json");
    }
}
