using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public static List<Country> GetFakeCountries()
        {
            return new List<Country>()
            {
                new Country() {  CountryId= 0, CountryName = "Morocco" },
                new Country() {  CountryId= 1, CountryName = "American Samoa" },
                new Country() {  CountryId= 2, CountryName = "New Zealand" },
                new Country() {  CountryId= 3, CountryName = "Channel Islands" },
            };
        }
    }
}
