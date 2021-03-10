using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public interface ICitiesController
    {
        ActionResult GetCities();
        ActionResult GetCity(int id);
    }
}
