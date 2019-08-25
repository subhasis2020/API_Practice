using ApplicationService.Abstraction;

using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Concreat
{
    public class CustomerService : ICustomer
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        
        protected virtual void Dispose(bool disposing)
        {

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Repository.Customer> GetCustomerData(string id = null)
        {
            return unitOfWork.CustomerRepository.Get();
        }
    }
}
