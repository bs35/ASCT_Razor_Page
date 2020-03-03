using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ASCT_Razor_Page.Models;

namespace ASCT_Razor_Page.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // property to record the user's input Tail Number from 
        // the TechnicianUI page; supports GET; must be 
        // replaced with different communication method
        [BindProperty(SupportsGet = true)]
        public String TailNumber { get; set; }

        // property to output the database fetch result to the user
        // in the TechnicianUI 
        [BindProperty]
        public Aircraft Unit { get; set; }
        //
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        { 
            if (ModelState.IsValid == false)
            {
                // add the input check later
                return Page();
            }
            return Page();
        }
    }
}
