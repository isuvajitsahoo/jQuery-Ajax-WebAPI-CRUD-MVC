using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_WebAPI_CRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Training_19Sep18_PuneEntities1 entities = new Training_19Sep18_PuneEntities1();
            List<Customer1234> customers = entities.Customer1234.ToList();
            if (customers.Count == 0)
            {
                customers.Add(new Customer1234());
            }

            return View(customers);
        }
    }
}