using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.API.Dto;

namespace Restaurants.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetRestaurants()
        {
            //List of restaurants
            var allRestaurants = new List<Restaurants.API.Models.Restaurant>()
            {
                new Restaurants.API.Models.Restaurant()
                {
                    Id = 1,
                    Name = "First Restaurant",
                    Cuisine = "Italian"
                },
                new Restaurants.API.Models.Restaurant()
                {
                    Id = 2,
                    Name = "Second Restaurant",
                    Cuisine = "Mexican"
                },
            };

            return Ok(allRestaurants);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetRestaurantById(int id)
        {
            var newRestaurant = new Models.Restaurant()
            {
                Id = 1,
                Name = "First Restaurant",
                Cuisine = "Italian"
            };

            return Ok(newRestaurant);
        }


        [HttpPost]
        public IActionResult AddNewRestaurant([FromBody] PostRestaurantDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRestaurant([FromBody] PutRestaurantDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteRestaurant(int id)
        {
            return Ok();
        }

    }
}


