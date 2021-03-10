using CityInfo.API.Controllers;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace CityInfo.Tests
{
    public class CitiesControllerTests
    {
        [Fact]
        public void GetCityReturnNotFound()
        {
            var sut = new CitiesController();

            ActionResult response = sut.GetCity(4);

            Assert.IsType<Microsoft.AspNetCore.Mvc.NotFoundResult>(response);
        }

       [Fact]
       public void GetCityReturnOkObjectResult()
        {
            var sut = new CitiesController();

            ActionResult response = sut.GetCity(1);

            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public void GetCityReturnACity()
        {
            var sut = new CitiesController();

            OkObjectResult response = sut.GetCity(1) as OkObjectResult;
            CityDTO city = response.Value as CityDTO;

            Assert.NotNull(response);
            Assert.Equal(200, response.StatusCode);
            Assert.Equal("New York City", city.Name);
        }

        [Fact]
        public void GetCitiesReturnAListOfCities()
        {
            var sut = new CitiesController();

            OkObjectResult response = sut.GetCities() as OkObjectResult;
            List<CityDTO> cities = response.Value as List<CityDTO>;

            Assert.NotNull(response);
            Assert.Equal(200, response.StatusCode);
            Assert.Equal(3, cities.Count);
        }
    }
}
