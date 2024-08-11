using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Campagin:IEntities
    {

        public int Id { get; set; }

        public string CampaginName { get; set; }

        public string CampaginDescription { get; set;  }

        public int CampaginPercentPrice { get; set; }   


    }
}
