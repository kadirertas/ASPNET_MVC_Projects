using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ICampaginManager
    {
        void Add(Campagin campagin);

        void Remove(Campagin campagin);

        void Update(Campagin campagin);
    }
}
