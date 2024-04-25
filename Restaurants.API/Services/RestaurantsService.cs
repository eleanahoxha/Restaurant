using System;
using Microsoft.EntityFrameworkCore;
using Restaurants.API.Dto;

namespace Restaurants.API.Services
{
    public class RestaurantsService : IRestaurantsService
    {
        private AppDbContext _context;
        public RestaurantsService(AppDbContext context)
        {
            _context = context;
        }


        public List<Models.Restaurant> GetAllRestaurants()
        {
            var allRestaurants = _context.Restaurants.ToList();
            return allRestaurants;
        }

        public Models.Restaurant AddRestaurant(PostRestaurantDto restaurant)
        {
            var newRestaurant = new Models.Restaurant()
            {
                Name = restaurant.Name,
                Cuisine = restaurant.Cuisine
            };

            _context.Restaurants.Add(newRestaurant);
            _context.SaveChanges();

            return newRestaurant;
        }

        public void DeleteRestaurant(int id)
        {
            var restaurantDb = _context.Restaurants
                .FirstOrDefault(n => n.Id == id);

            _context.Restaurants.Remove(restaurantDb);
            _context.SaveChanges();
        }



        public Models.Restaurant GetRestaurantById(int id)
        {
            var newRestaurant = _context.Restaurants
                .FirstOrDefault(n => n.Id == id);

            return newRestaurant;
        }

        public Models.Restaurant UpdateRestaurant(PutRestaurantDto restaurantData, int id)
        {
            var restaurantDb = _context.Restaurants
                .FirstOrDefault(n => n.Id == id);

            restaurantDb.Name = restaurantData.Name;
            _context.Restaurants.Update(restaurantDb);

            _context.SaveChanges();

            return restaurantDb;
        }
    }
}
