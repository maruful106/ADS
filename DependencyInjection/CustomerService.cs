using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class CustomerService
    {
        private readonly ILogger _logger;

        public CustomerService(ILogger logger)
        {
            _logger = logger;
        }
        public void AddCustomer(string customerName)
        {
            _logger.Log(customerName);
        }
    }
}
