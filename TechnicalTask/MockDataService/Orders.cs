using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnicalTask.Models;

namespace TechnicalTask.MockDataService
{
    public class Orders
    {
        public static List<CustomerOrder> OrderList
        {
            get
            {
                return new List<CustomerOrder>
                {
                    new CustomerOrder
                    {
                        OrderId = 1,
                        CustomerName = "joe bloggs",
                        OrderDate = DateTime.Now,
                        Unit = new List<StockItem>
                        {
                            new StockItem { 
                                UnitName = "Item 1",
                                Cost = 10,
                                Quantity = 2,
                                UnitPrice = 1
                            }, new StockItem
                            {
                                UnitName = "Item 2",
                                Cost = 10,
                                Quantity = 15,
                                UnitPrice = 1
                            }, new StockItem
                            {
                                UnitName = "Item 3",
                                Cost = 10,
                                Quantity = 25,
                                UnitPrice = 1
                            }, new StockItem
                            {
                                UnitName = "Item 4",
                                Cost = 10,
                                Quantity = 40,
                                UnitPrice = 1
                            }
                        }
                    }
                };
            }
        }
    }
}