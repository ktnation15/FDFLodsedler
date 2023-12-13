using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Leaders
{
    public class OpretLederModel : PageModel
    {
        private Ileder ileder;

        [BindProperty]

        public Leder leder { get; set; }

        public OpretLederModel(Ileder ileder)
        {
            this.ileder = ileder;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()

        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            ileder.AddLeder(leder);

            return RedirectToPage("/Leaders/VisLeder");

        }
    }
}
