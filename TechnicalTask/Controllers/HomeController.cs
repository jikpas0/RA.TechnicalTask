using System.Web.Mvc;
using TechnicalTask.MockDataService;
using TechnicalTask.Models;

namespace TechnicalTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(CustomerOrder customerOrder = null)
        {
            /*Orders customerOrder = new Orders();
            var orders = customerOrder.OrderList;*/
            if (string.IsNullOrEmpty(customerOrder?.CustomerName))
            {
                customerOrder = new CustomerOrder();
                customerOrder.Unit = Stock.OrderList;
            }
            else
            {
                customerOrder.OrderId = 1;
            }

            return View(customerOrder);
        }
    }
}