using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concerete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            return true;

        }

    
    }
}
