using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Sales
{
    public class SletSalgModel : PageModel
    {
        private ISalg Salg;

        [BindProperty]


        public Salg salg { get; set; }

        public SletSalgModel(ISalg salg)
        {
            Salg = salg;
        }

        public void OnGet(int sid)
        {
            salg = Salg.GetAllSalg(sid);
        }

        public IActionResult OnPost()
        {


            Salg.RemoveSalg(salg);

            return RedirectToPage("/Sales/VisSalg");

        }
    }
}