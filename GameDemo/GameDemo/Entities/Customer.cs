﻿using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Customer : IEntities
    {


        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Balance { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
