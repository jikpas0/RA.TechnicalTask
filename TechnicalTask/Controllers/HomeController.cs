using System.Web.Mvc;
using TechnicalTask.MockDataService;
using TechnicalTask.Models;

namespace TechnicalTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Orders customerOrder = new Orders();
            var orders = customerOrder.OrderList;

            return View(orders);
        }
    }
}