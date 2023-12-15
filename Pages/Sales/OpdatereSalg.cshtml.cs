using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Sales
{
    public class OpdatereSalgModel : PageModel
    {
        private ISalg Salg;
        [BindProperty]
        public Salg salg { get; set; }

        public OpdatereSalgModel(ISalg salg)
        {
            Salg = salg;
        }

        public void OnGet(int sid)
        {
            salg = Salg.GetAllSalg(sid);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Salg.Update(salg);

            return RedirectToPage("/Sales/VisSalg");

        }
    }
}