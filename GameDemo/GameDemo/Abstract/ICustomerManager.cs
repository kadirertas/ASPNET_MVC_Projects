using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ICustomerManager
    {

        void Add(Customer customer);
        
        void Remove(Customer customer);

        void Update(Customer customer); 
    }
}
