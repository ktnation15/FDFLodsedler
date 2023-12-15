using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Leaders
{
    public class OpdatereLederModel : PageModel
    {
        private Ileder leder;




        public OpdatereLederModel(Ileder leder)
        {
            this.leder = leder;
        }

        [BindProperty]
        public Leder Leder { get; set; }


        public void OnGet(int sid)
        {
            Leder = leder.GetAlleder(sid);

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            leder.UpdateLeder(Leder);


            return RedirectToPage("/Leaders/VisLeder");
        }
    }
}