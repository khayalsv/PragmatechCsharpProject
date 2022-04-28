using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

        public static List<City> GetFakeCities()
        {
            return new List<City>()
            {
                new City() {  CityId=11, CityName = "Leicester", CountryId=0 },
                new City() {  CityId=12, CityName = "Sunderland", CountryId=0 },
                new City() {  CityId=13, CityName = "Bath", CountryId=1 },
                new City() {  CityId=14, CityName = "Leeds", CountryId=1 },
                new City() {  CityId=15, CityName = "Dallas", CountryId=2 },
                new City() {  CityId=16, CityName = "Lancaster", CountryId=2 },
                new City() {  CityId=17, CityName = "Tampa", CountryId=2 },
                new City() {  CityId=18, CityName = "Christchurch", CountryId=2 },
                new City() {  CityId=19, CityName = "Laredo", CountryId=3 },
                new City() {  CityId=20, CityName = "Indianapolis", CountryId=3 },
            };
        }

    }
}
