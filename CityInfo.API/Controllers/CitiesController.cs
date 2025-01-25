using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{

    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities);
        }
    }
}
