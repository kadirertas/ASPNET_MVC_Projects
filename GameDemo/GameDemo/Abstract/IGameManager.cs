using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);

        void Remove(Game game);

        void Update(Game game);
    }
}
