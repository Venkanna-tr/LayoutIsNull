using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MessWala.Data.Models.ViewModels.AccountViewModel;
using MessWala.Data.Models;

namespace MessWala.Web.Pages
{
    public class IndexModel : PageModel
    {

        FoodExContext _context = new FoodExContext();

        [BindProperty]
        public LoginDto LoginDto { get; set; }
        public void OnGet()
        {

        }
        public ActionResult OnPostAsync()
        {
            //  dto =  (from usr in  _context.Users.Where(e=>e.UserName==dto.UserName
            //  )  )
            return RedirectToPage("./Index");
        }
    }
}
