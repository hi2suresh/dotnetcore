using System;

namespace OdeToFoodCopy.Core
{
    public class Restaurants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CusineType Cusine { get; set; }
    }
}
