using KSResumo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.ViewModels
{
    public class HomeVM
    {
        public List<Home> Homes { get; set; }
        public List<About> Abouts { get; set; }
        public List<Portfolio> Portfolios { get; set; }

    }
}
