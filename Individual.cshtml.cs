using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Candy_Store_App2.Pages
{
    public class IndividualModel : PageModel
    {
        public void OnGet(int? id)
        {
            System.Diagnostics.Debug.WriteLine(id);
        }
    }
}