using OdeToFoodCopy.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OdeToFoodCopy.Data
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurentData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
               new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine=CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
