﻿using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string ShoppingAddress { get; set; }
        public int? Uid { get; set; }
    }
}
