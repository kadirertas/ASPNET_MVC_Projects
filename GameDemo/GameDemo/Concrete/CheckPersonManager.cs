using GameDemo.Abstract;
using GameDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CheckPersonManager : ICustomerCheckService
    {
        public bool CustomerRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            // Asenkron metodu senkron olarak bekleyip sonucu alıyoruz.
            var response = client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year)
                .GetAwaiter().GetResult();

            // Sonucu döndürüyoruz.
            return response.Body.TCKimlikNoDogrulaResult;
        }
    }
}
