using NoTech.Extension;
using NoTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.ViewModels
{
    public class PaginationVM
    {
        public List<Counter> counters { get; set; }
        public PaginationModel Pagination { get; set; }
    }
}
