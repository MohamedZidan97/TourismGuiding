﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Tourisms.Update
{
    public class TourismsUpdateCommend : IRequest<ResponseGeneral>
    {
        public int TourismId { get; set; }

        public string TourismName { get; set; }

        public string? Description { get; set; }

    }
}
