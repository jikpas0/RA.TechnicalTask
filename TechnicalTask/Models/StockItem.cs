using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTask.Models
{
    public class StockItem
    {
        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public bool Ordered { get; set; }
        public decimal TotalCost {
	        get { return CalculateDiscount(); }
        }

        public decimal CalculateDiscount()
        {
            var totalCost = UnitPrice * Cost;

            if (Quantity > 10 && Quantity < 20)
            {
                totalCost = totalCost - (totalCost * (decimal)0.05);
            }

            if (Quantity > 20 && Quantity < 30)
            {
                totalCost = totalCost - (totalCost * (decimal)0.10);
            }

            if (Quantity > 30)
            {
                totalCost = totalCost - (totalCost * (decimal)0.15);
            }

            return totalCost;
        }
    }
}