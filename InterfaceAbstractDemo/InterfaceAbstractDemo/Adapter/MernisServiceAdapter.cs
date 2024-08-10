using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
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
