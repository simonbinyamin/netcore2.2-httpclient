﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpAttributesCore.Models
{

    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int? Numberofsections { get; set; }
    }
}
