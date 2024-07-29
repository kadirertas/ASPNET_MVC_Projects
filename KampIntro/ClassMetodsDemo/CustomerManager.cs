using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodsDemo
{
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Welcome(customer.CustomerBalance);
            Console.WriteLine((customers.Count ) + ". Müşteri olarak " + customer.CustomerName + " Eklendi");
        }



        public void Write ( ) 
        { 
        
                foreach( var item in customers) 
            {

                Console.WriteLine(item.CustomerName + " :: " + item.CustomerBalance+"$ \n"); 
            
            }
        
        
        }



        private void Welcome (double CustomerBalance) 
        {
        
        
              if ( CustomerBalance>20000) 
            {

                Console.WriteLine("Vay anam babam hoş gelmissen\n"); 
            
            }
            else 
            {

                Console.WriteLine("Ulan bu günde sinek avlıyoz geç içeri \n"); 
            
            }
        }

    }
}
