using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase, ICitiesController
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            List<CityDTO> citiesToReturn = CitiesDataStore.Current.Cities;

            return Ok(citiesToReturn);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == id);

            if(cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
