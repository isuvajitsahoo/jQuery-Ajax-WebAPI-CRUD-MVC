using System;
using System.Web.Http;
using System.Linq;

namespace jQuery_AJAX_WebAPI_CRUD_MVC.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/InsertCustomer")]
        [HttpPost]
        public Customer1234 InsertCustomer(Customer1234 _customer)
        {
            using (Training_19Sep18_PuneEntities1 entities = new Training_19Sep18_PuneEntities1())
            {
                entities.Customer1234.Add(_customer);
                entities.SaveChanges();
            }

            return _customer;
        }

        [Route("api/AjaxAPI/UpdateCustomer")]
        [HttpPost]
        public bool UpdateCustomer(Customer1234 _customer)
        {
            using (Training_19Sep18_PuneEntities1 entities = new Training_19Sep18_PuneEntities1())
            {
                Customer1234 updatedCustomer = (from c in entities.Customer1234
                                            where c.CustomerId == _customer.CustomerId
                                            select c).FirstOrDefault();
                updatedCustomer.Name = _customer.Name;
                updatedCustomer.Country = _customer.Country;
                entities.SaveChanges();
            }

            return true;
        }

        [Route("api/AjaxAPI/DeleteCustomer")]
        [HttpPost]
        public void DeleteCustomer(Customer1234 _customer)
        {
            using (Training_19Sep18_PuneEntities1 entities = new Training_19Sep18_PuneEntities1())
            {
                Customer1234 customer = (from c in entities.Customer1234
                                     where c.CustomerId == _customer.CustomerId
                                     select c).FirstOrDefault();
                entities.Customer1234.Remove(customer);
                entities.SaveChanges();
            }
        }
    }
}
