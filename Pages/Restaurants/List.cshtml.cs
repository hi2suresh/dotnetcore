using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFoodCopy.Core;
using OdeToFoodCopy.Data;

namespace OdeToFoodCopy.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurentData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurentData  restaurentData )
        {
            this.config = config;
            this.restaurantData = restaurentData;
        }
        public void OnGet(string searchTerm)
        {
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}
