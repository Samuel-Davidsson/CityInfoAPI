﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class PointsOfInterestDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfIntrest { get
            {
                return PointOfIntrest.Count;
            }
         }

        public ICollection<PointsOfInterestDto> PointOfIntrest { get; set; }
        = new List<PointsOfInterestDto>();
    }
}