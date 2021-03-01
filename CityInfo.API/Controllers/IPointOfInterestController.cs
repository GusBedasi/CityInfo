using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public interface IPointOfInterestController
    {
        IActionResult GetPointsOfInterest(int cityId);
        IActionResult GetPointOfInterest(int cityId, int pointOfInterestId);
    }
}
