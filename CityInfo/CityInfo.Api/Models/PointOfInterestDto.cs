using System.Collections.Generic;

namespace CityInfo.Api.Models
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfIntrest { get
            {
                return PointOfIntrest.Count;
            }
         }

        public ICollection<PointOfInterestDto> PointOfIntrest { get; set; }
        = new List<PointOfInterestDto>();
    }
}
