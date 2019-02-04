using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet()]
        public IActionResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);

            //return new JsonResult(new List<object>()
            //{
            //    new { id=1, Name="New York City"},
            //    new { id=2, Name="Antwerp"}
            //});
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityReturn == null)
            {
                return NotFound();
            }

            return Ok(cityReturn);
        }

    }
}