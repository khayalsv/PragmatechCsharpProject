using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSRazor.Data;
using KSRazor.Models;

namespace KSRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly KSRazor.Data.MyContext _context;

        public IndexModel(KSRazor.Data.MyContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
