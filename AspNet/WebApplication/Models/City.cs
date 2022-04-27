using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public static List<City> GetFakeCities()
        {
            return new List<City>()
            {
                new City(){Id=1,Name="Sumqayit",CountryId=1},
                new City(){Id = 2,Name = "Ankara",CountryId = 2 },
                new City(){Id = 3,Name = "Istanbul",CountryId = 2,},
                new City(){Id = 4,Name = "Baki",CountryId = 1}
            };
        }

    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Country> GetFakeContries()
        {
            return new List<Country>()
            {
                new Country(){Id=1,Name="Azerbaycan",},
                new Country(){Id = 2,Name = "Turkiye",},

            };
        }
    }
}
