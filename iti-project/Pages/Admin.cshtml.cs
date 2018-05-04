using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using iti_project.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iti_project.Pages
{
    public class AdminModel : PageModel
    {

        [BindProperty]
        public IFormFile Upload { get; set; }
        public List<User> Users { get; set; }

        public AdminModel()
        {
            using (var db = new DatabaseContext())
            {
                Users = db.Users.ToList();
            }
        }

        public User GetUserByName(string name)
        {
            foreach(User user in Users)
            {
                if(user.Name.Equals(name))
                {
                    return user;
                }
            }
            return null;
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
