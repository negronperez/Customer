using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home
        public ActionResult Customer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Customer(Entity.Customer obj)
        {
            obj.ID = Guid.NewGuid();
            BusinessLogic.CustomerManager.Insert(obj);
            return RedirectToAction("Address", new { id = obj.ID.ToString() });//querystring
        }
        public ActionResult Address(Guid id)
        {
            if (id == Guid.Empty)
            {
                return RedirectToAction("Index");
            }

            var customer = BusinessLogic.CustomerManager.GetById(id);

            return View(new Entity.CustomerAddress()
            {
                CustomerId = customer.CustomerId
            });
        }
        [HttpPost]
        public ActionResult Address(Entity.CustomerAddress obj)
        {
            BusinessLogic.CustomAddresManager.Insert(obj);
            return View("Results");
        }
        public ActionResult Results()
        {
            return View();
        }
        public ActionResult CustomerDetails(Guid ID)
        {   
            if (ID == Guid.Empty)
            {
                RedirectToAction("Index");
            }

            var customer = BusinessLogic.CustomerManager.GetById(ID);

            return View(customer);
        }
    }
}