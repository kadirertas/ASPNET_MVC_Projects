 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class TuzelMusteri: Musteri  // Burdaki işleme miras alma denir (Inheritance) dir özetle  Bu 
        
        // Individual = Tüzel 
    {
        /* ONEMLİ NOT::Bir veri üzewrinde matematiksel bir işlem yapılmıyorsa
     * eğer onu stirng olarak almak daha iyi sonuçlar verecektir */

        
        public string CompanyName { get; set; } // Şirket Adı 
        public string TaxNumber { get; set; } // Vergi Numarası 
    }
}
