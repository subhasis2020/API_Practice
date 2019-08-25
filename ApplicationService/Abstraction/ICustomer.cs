using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Abstraction
{
    public interface ICustomer : IDisposable
    {
        IEnumerable<Repository.Customer> GetCustomerData(string id = null);
    }
}
