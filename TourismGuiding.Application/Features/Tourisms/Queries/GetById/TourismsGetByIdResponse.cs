﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismGuiding.Application.Features.Tourisms.Queries.GetById
{
    public class TourismsGetByIdResponse
    {
        public int TourismId { get; set; }

        public string TourismName { get; set; }

        public string? Description { get; set; }
    }
}
