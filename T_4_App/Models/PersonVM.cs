﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_4_App.Models
{
    public class PersonVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int PositionId { get; set; }
        public PositionVM Position { get; set; }

        public int RegionId { get; set; }
        public RegionVM Region { get; set; }

        public List<OrderVM> Orders { get; set; }
    }
}
