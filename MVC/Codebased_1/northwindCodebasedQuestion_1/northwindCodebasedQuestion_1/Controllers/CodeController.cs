using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using northwindCodebasedQuestion_1.Models;
namespace northwindCodebasedQuestion_1.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomersInGermany()
        {
            var germanyCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanyCustomers);
        }
        public ActionResult CustomerDetailsByOrderId(int orderId = 10248)
        {
            var customer = db.Customers
                .Where(c => c.Orders.Any(o => o.OrderID == orderId))
                .SingleOrDefault();

            if (customer == null)
            {
                return HttpNotFound(); // Return a 404 status code if the customer is not found.
            }

            return View(customer);
        }
    }
}