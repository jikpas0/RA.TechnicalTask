using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTask.Models
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public StockItem Unit { get; set; }
    }
}