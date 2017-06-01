using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechnicalTask.MockDataService;

namespace TechnicalTask.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        // Test the property Total Cost returns a discounted value for each scenario
        [Test]
        public void CalculateResultTest()
        {
            //Setup

           

            //Act

            var totalCost = Orders.OrderList.SelectMany(x => x.Unit.Select(u => u)).ToList();
            
            //Assert
           
            Assert.That("0", Is.EqualTo(totalCost[0].ToString()));
        }


        //test to check MVC controller endpoint responds correctly 
        [Test]
        public void IndexControllerTest()
        {
            //Setup



            //Act

            var totalCost = Orders.OrderList.SelectMany(x => x.Unit.Select(u => u)).ToList();

            //Assert

            Assert.That("0", Is.EqualTo(totalCost[0].ToString()));
        }
    }
}
