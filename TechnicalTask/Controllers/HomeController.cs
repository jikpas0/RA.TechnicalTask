using System.Linq;
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
            //Checks to ensure nothing has been ordered by this customer, would have been better to split out the ordered items from the available items in the CustomerOrder model
            if (customerOrder == null || 
                (string.IsNullOrEmpty(customerOrder?.CustomerName) && customerOrder.OrderId == null)) 
            {
                customerOrder = new CustomerOrder();
                customerOrder.Unit = Stock.OrderList;
            }
            else
            {
                //Would prefer to generate order number from a auto incremented data source
                customerOrder.OrderId = 1;
            }

            return View(customerOrder);
        }
    }
}