using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CustomerManager : ICustomerManager

    {   
          private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
           _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CustomerRealPerson(customer)) 
            {

                Console.WriteLine(customer.FirstName + "Adlı kullanıcı sisteme kaydedildi" ); 
            
            }
            else 
            {
                throw new Exception("Böyle bir kullanıcı E-devlet sisteminde kayıtlı değildir"); 
            
            }
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Adlı kullanıcı sistemden silindi");

        }

        public void Update(Customer customer)
        {

            Console.WriteLine("Kullanıcı güncelleme işlemi başarılı");
        }
    }
}
