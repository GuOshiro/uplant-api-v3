﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uplantApi.Models.Generic;

namespace uplantApi.Models
{
    public class Farmer
    {
        public Guid Id { get; set; }
        public GenericPerson genericPPerson { get; set; }
    }
}
