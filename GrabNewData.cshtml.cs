using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Candy_Store_App2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Candy_Store_App2.Pages
{
    public class GrabNewDataModel : PageModel
    {
        public ApplicationDbContext _context { get; set; }

        public IList<Store> Store { get; set; }

        public GrabNewDataModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            Store = await _context.Store.ToListAsync();
        }
    }
}