using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyun mağzaya Eklendi" );
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı oyun mağzadan kaldırıldı");

        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncelleme işlemi başarıyla tamamlandı");
        }
    }
}
