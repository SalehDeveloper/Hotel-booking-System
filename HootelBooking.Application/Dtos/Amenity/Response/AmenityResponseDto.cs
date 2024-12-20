﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootelBooking.Application.Dtos.Amenity.Response
{
    public  class AmenityResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
