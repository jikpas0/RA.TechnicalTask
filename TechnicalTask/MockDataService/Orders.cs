using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnicalTask.Models;

namespace TechnicalTask.MockDataService
{
    public class Orders
    {
        public List<CustomerOrder> OrderList
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
                        Unit = new StockItem
                        {
                            Cost = 10,
                            Quantity = 2,
                            UnitPrice = 1
                        }
                    },
                    new CustomerOrder
                    {
                        OrderId = 2,
                        CustomerName = "allan bloggs",
                        OrderDate = DateTime.Now,
                        Unit = new StockItem
                        {
                            Cost = 10,
                            Quantity = 15,
                            UnitPrice = 1
                        }
                    },
                    new CustomerOrder
                    {
                        OrderId = 3,
                        CustomerName = "jeremy bloggs",
                        OrderDate = DateTime.Now,
                        Unit = new StockItem
                        {
                            Cost = 10,
                            Quantity = 25,
                            UnitPrice = 1
                        }
                    },
                    new CustomerOrder
                    {
                        OrderId = 4,
                        CustomerName = "bingo bloggs",
                        OrderDate = DateTime.Now,
                        Unit = new StockItem
                        {
                            Cost = 10,
                            Quantity = 40,
                            UnitPrice = 1
                        }
                    }
                };
            }
        }
    }
}