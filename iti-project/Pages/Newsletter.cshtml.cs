using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using iti_project.Data;

namespace iti_project.Pages
{
    public class NewsletterModel : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost()
        {
            var emailadress = Request.Form["email"];

            using (var db = new DatabaseContext())
            {
                try
                {
                    db.Emails.Add(new Email(emailadress));
                    db.SaveChanges();
                    ViewData["confirmation"] = $"{emailadress} is registered!";
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException e)
                {
                    ViewData["confirmation"] = $"{emailadress} was NOT registered - This email is already registered!";
                }
                catch (Exception e)
                {
                    ViewData["confirmation"] = $"{emailadress} was NOT registered - Unknown error!";
                }
            }
        }
    }
}