using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{

    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object> {
       new { name= "Agra",id=1 },
       new { name= "Cheerapunji",id=2 },
        new { name= "Shimla",id=3 },

        });

        }
    }
}
