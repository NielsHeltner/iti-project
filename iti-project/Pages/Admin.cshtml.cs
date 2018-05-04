using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iti_project.Pages
{
    public class AdminModel : PageModel
    {

        [BindProperty]
        public IFormFile Upload { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            var file = Path.Combine("wwwroot/images/gallery/", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
        }
    }
}
