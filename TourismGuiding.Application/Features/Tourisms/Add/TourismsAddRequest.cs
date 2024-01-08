using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Application.Features.ResponseGeneration;

namespace TourismGuiding.Application.Features.Tourisms.Add
{
    public class TourismsAddRequest : IRequest<ResponseGeneral>
    {
        public string TourismName { get; set; }

        public string? Description { get; set; }
    }
}
