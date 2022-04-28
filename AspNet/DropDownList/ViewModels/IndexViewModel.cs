using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ViewModels
{
    public class IndexViewModel
    {
        public int SelectedCityId { get; set; }
        public int SelectedCountryId { get; set; }

        public SelectList CitiesData { get; set; }
        public SelectList CountriesData { get; set; }
    }
}
