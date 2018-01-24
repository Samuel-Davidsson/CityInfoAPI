using System.Collections.Generic;

namespace CityInfo.Api.Models
{
    public class CityDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberPointsOfIntrest { get; set; }

        public ICollection<PointsOfInterestDto> PointsOfInterest { get; set; } = new List<PointsOfInterestDto>();
    }
}
