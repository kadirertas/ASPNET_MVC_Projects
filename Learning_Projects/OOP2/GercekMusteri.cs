using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class GercekMusteri:Musteri // Gerçek = Coorprote
    {
        //implement = uygulamak 

        // Buna benzer varlık Entitiy gibi özlellik barındıran class larda operasyonlar bulunmaz  

        public string TcNumber { get; set; } // Tc Kimlik Numarası 
        public string FirstName { get; set; } // Adı 
        public string LastName { get; set; } // Soyadı 
   
    }
}
