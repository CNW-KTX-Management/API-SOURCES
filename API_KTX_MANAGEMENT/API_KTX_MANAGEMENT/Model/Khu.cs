﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_KTX_MANAGEMENT.Model
{
    public class Khu
    {
        [Key]
        public int Id { get; set; }
        public string TenKhu { get; set; }
    }
}
