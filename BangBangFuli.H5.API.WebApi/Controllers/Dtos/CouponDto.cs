﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangBangFuli.H5.API.WebAPI.Controllers.Dtos
{
    public class CouponDto
    {
        public int Code { get; set; } 
        public DateTime ValidityDate { get; set; }

        public int AvaliableCount { get; set; }

        public int TotalCount { get; set; }
    }
}
