using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointOfInterestController : ControllerBase, IPointOfInterestController
    {
        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            CityDTO city = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{pointOfInterestId}")]
        public IActionResult GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            CityDTO city = CitiesDataStore.Current.Cities
                .FirstOrDefault(x => x.Id == cityId);

            PointOfInterestDTO pointOfInterest = city.PointsOfInterest
                .FirstOrDefault(x => x.Id == pointOfInterestId);

            if(pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }
    }
}
