using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    interface ICitiesController
    {
        IActionResult GetCities();
        IActionResult GetCity(int id);
    }
}
