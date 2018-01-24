using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            new CityDto()
            {
                Id = 1,
                Name = "Stockholm",
                Description = "Capital of Sweden."
            },

            new CityDto()
            {
                Id = 2,
                Name = "Kalmar",
                Description = "Classic city."
            },

            new CityDto()
            {
                Id = 3,
                Name = "Gotlaborg",
                Description = "The real capital of Sweden.."
            }
          };
        }
    }
}
