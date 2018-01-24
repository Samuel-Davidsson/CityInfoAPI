﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CityInfo.Api.Controllers
{

    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new {id=1, Name="Stockholm"},
                new {id=2, Name="Kalmar"}
            });
        }
    }
}
