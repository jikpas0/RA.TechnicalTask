using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using TechnicalTask.MockDataService;
using TechnicalTask.Controllers;
using TechnicalTask.Models;

namespace TechnicalTask.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        // Test the property 'TotalCost' returns a discounted value for each scenario of quantity and price
        [Test]
        public void CalculateResultTest()
        {
            //Setup

            var mockOrders = Orders.OrderList;

            //Act

            var totalCost = mockOrders.Unit.Select(u => u).ToList();

            //Assert
            
            Assert.That(totalCost[0].TotalCost.ToString(), Is.EqualTo("5"));
            Assert.That(totalCost[1].TotalCost.ToString("0.00"), Is.EqualTo("14.25"));
            Assert.That(totalCost[2].TotalCost.ToString("0.0"), Is.EqualTo("22.5"));
            //Expected is not as the example shown in the task document value 34.5 being incorrect
            Assert.That(totalCost[3].TotalCost.ToString("0.0"), Is.EqualTo("34.0"));
        }
        
        //test to check MVC controller endpoint responds correctly 
        [TestCase("null", "1", "Item 1", "", true)]
        [TestCase("blankObject", "1", "Item 1", "", true)]
        [TestCase("mockData", "1", "Item 1", "1", false)]
        [Test]
        public void IndexControllerTest(string controllerTestParams, string value, string name, string orderid, bool isEmptyBlankOrder)
        {
            //Setup
             CustomerOrder inputTestParam = null;
             switch (controllerTestParams)
             {
                 case "null":
                     break;
                 case "blankObject":
                     inputTestParam = new CustomerOrder();
                     break;
                 case "mockData":
                     inputTestParam = Orders.OrderList;
                     break;
             }    

            HomeController homeController = new HomeController();

            //Act

            var result = homeController.Index(inputTestParam) as ViewResult;
            var customerOrder = (CustomerOrder)result.Model;

            //Assert

            Assert.That(customerOrder.OrderId.ToString(), Is.EqualTo(orderid));
            Assert.That(customerOrder.OrderDate.ToShortDateString(), Is.EqualTo(isEmptyBlankOrder ? DateTime.MinValue.ToShortDateString() : DateTime.Now.ToShortDateString()));
            Assert.That(customerOrder.CustomerName, Is.EqualTo(isEmptyBlankOrder ? null : "joe bloggs"));
            Assert.That(customerOrder.Unit[0].UnitName, Is.EqualTo(name));
            Assert.That(customerOrder.Unit[0].UnitPrice.ToString(), Is.EqualTo(isEmptyBlankOrder ? value : "1"));
            Assert.That(customerOrder.Unit[0].Quantity.ToString(), Is.EqualTo(isEmptyBlankOrder ? value : "5"));
            Assert.That(customerOrder.Unit[0].Ordered, Is.EqualTo(false));
        }
    }
}
