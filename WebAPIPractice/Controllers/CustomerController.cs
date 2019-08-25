using ApplicationService.Abstraction;
using ApplicationService.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIPractice.Controllers
{
    public class CustomerController : ApiController
    {
        ICustomer customerService = new CustomerService();

        [HttpGet]
        [Route("API/Customer/GetCustomer")]
        [Route("API/Customer/GetCustomer")]
        [Route("API/Customer/GetCustomerDetails")]
        public IHttpActionResult Get(int custId = 0)
        {
            var customers = customerService.GetCustomerData();
            return Ok(customers.Take(10));
        }
    }
}
