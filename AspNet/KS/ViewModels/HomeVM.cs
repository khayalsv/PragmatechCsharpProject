using KS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KS.ViewModels
{
    public class HomeVM
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<HomePageM> HomePageMs { get; set; }
    }
}
