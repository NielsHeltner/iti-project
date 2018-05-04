using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iti_project.Pages
{
    public class GalleryModel : PageModel
    {
        public string[] Files { get; set; }
        public List<string> FilesNames { get; set; }
        public void OnGet()
        {
            FilesNames = new List<string>();
            Files = Directory.GetFiles("wwwroot/images/gallery/");
            foreach (var strFile in Files)
            {
                FilesNames.Add(Path.GetFileName(strFile));
            }
        }
    }
}
