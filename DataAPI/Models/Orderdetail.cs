﻿using System;
using System.Collections.Generic;

namespace DataAPI.Models
{
    public partial class Orderdetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProId { get; set; }
        public int? ProNum { get; set; }
    }
}
