using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Leaders
{
    public class SletLederModel : PageModel
    {
        private Ileder Ileder;

        public SletLederModel(Ileder ileder)
        {
            Ileder = ileder;
        }

        [BindProperty]
        public Leder Leder { get; set; }




        public void OnGet(int sid)
        {

            Leder = Ileder.GetAlleder(sid);
        }

        public IActionResult OnPost()
        {

            Ileder.RemoveLeder(Leder);

            return RedirectToPage("/Leaders/VisLeder");
        }
    }
}
