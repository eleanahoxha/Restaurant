using Restaurants.API.Dto;

namespace Restaurants.API.Services
{
    public interface IRestaurantsService
    {
        List<Models.Restaurant> GetAllRestaurants();
        Models.Restaurant GetRestaurantById(int id);
        Models.Restaurant AddRestaurant(PostRestaurantDto restaurant);
        Models.Restaurant UpdateRestaurant(PutRestaurantDto restaurantData, int id);
        void DeleteRestaurant(int id);
    }
}
