using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CampaginManager : ICampaginManager
    {
        public void Add(Campagin campagin)
        {
            Console.WriteLine(campagin.CampaginName + " Adlı kampanya sisteme dahil edildi ");
        }

        public void Remove(Campagin campagin)
        {
            Console.WriteLine(campagin.CampaginName + " Adlı kampanya sistemden silindi ");

        }

        public void Update(Campagin campagin)
        {
            Console.WriteLine("Kampanya Güncelleme İşlemi Başarılı ");
        }
    }
}
