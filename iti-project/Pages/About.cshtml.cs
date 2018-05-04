using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iti_project.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iti_project.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public User Anton { get; set; }
        public User Niels { get; set; }
        public User Niclas { get; set; }


        public void OnGet()
        {
            Message = "Your application description page.";
            Anton = new User();
        }
    }
}
