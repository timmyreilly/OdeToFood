using OdeToFood.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        static InMemoryRestaurantData() // Not thread safe NO concurrent users 
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name="The house of Kobe" },
                new Restaurant {Id =2, Name="LJs and the Kat" },
                new Restaurant {Id = 3, Name="Kings Contrivance" }
            }; 
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;     
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id); 
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(newRestaurant);

            return newRestaurant; 
        }

        static List<Restaurant> _restaurants; 
    }
}
