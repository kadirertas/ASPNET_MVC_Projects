using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustmerService
    {

        public virtual void Save(Customer customer)
        {

            Console.WriteLine("Save to db" + customer.FirstName);
        }
    }
}
