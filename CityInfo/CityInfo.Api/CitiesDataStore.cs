using CityInfo.Api.Models;
using System.Collections.Generic;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited park in the world"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Emipre State Building",
                            Description = "Big Building"
                        }
                    }

                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Antwerp museum",
                            Description = "The most visited museum in the world"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Art gallery",
                            Description = "Lots of paintings"
                        }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "paris",
                    Description = "The one with the big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Triumph båg fan",
                            Description = "bred jävla väg"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The effeltower",
                            Description = "Big tower"
                        }
                    }
                }
            };
        }
    }
}

