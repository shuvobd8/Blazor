﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connection_Blazor.Data.Model
{
    public class BlaroRoom
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }

    }
}
