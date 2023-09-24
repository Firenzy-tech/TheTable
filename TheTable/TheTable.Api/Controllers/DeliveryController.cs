using Microsoft.AspNetCore.Mvc;
using TheTable.Api.Models;

namespace TheTable.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        [HttpGet("GetFood", Name = "GetFood")]
        public Food GetFood()
        {
            return new Food()
            {
                Description = "Ejemplo",
                FoodID = 1,
                Name = "Pollo Frito",
                Price = 15200M,
            };
        }
    }

}
