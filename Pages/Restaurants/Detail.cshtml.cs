using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFoodCopy.Core;
using OdeToFoodCopy.Data;

namespace OdeToFoodCopy.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurentData restaurantData;

        public Restaurant Restaurant { get; set; }
        public DetailModel(IRestaurentData restaurantData)
        {
            this.restaurantData = restaurantData;     
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant =  restaurantData.GetRestaurantById(restaurantId);
            if(Restaurant == null)
            {
                //return RedirectToPage("./NotFound");
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
