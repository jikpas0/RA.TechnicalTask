using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnicalTask.Models;

namespace TechnicalTask.MockDataService
{
    public class Stock
    {
        public static List<StockItem> OrderList
        {
            get
            {
                return new List<StockItem>
                {
                    new StockItem
                    {
                        UnitName = "Item 1",
                        Cost = 10,
                        Quantity = 1,
                        UnitPrice = 1,
                        Ordered = false
                    }, new StockItem
                    {
                        UnitName = "Item 2",
                        Cost = 12,
                        Quantity = 1,
                        UnitPrice = 1,
                        Ordered = false
                    }, new StockItem
                    {
                        UnitName = "Item 3",
                        Cost = 13,
                        Quantity = 1,
                        UnitPrice = 1,
                        Ordered = false
                    }, new StockItem
                    {
                        UnitName = "Item 4",
                        Cost = 15,
                        Quantity = 1,
                        UnitPrice = 1,
                        Ordered = false
                    }
                };
            }
        }
    }
}