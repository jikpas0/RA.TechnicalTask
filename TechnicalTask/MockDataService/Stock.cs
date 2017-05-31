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
                        Quantity = 2,
                        UnitPrice = 1
                    }, new StockItem
                    {
                        UnitName = "Item 2",
                        Cost = 12,
                        Quantity = 15,
                        UnitPrice = 1
                    }, new StockItem
                    {
                        UnitName = "Item 3",
                        Cost = 13,
                        Quantity = 25,
                        UnitPrice = 1
                    }, new StockItem
                    {
                        UnitName = "Item 4",
                        Cost = 15,
                        Quantity = 40,
                        UnitPrice = 1
                    }
                };
            }
        }
    }
}