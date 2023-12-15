using FDFLodsedler.Interface;
using FDFLodsedler.Migrations;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Payments
{
    public class OpdaterModel : PageModel
    {
        private IBetaling Betaling;
        [BindProperty]
        public Betaling Betalings { get; set; }

        public OpdaterModel(IBetaling betaling)
        {
            Betaling = betaling;
        }
        public void OnGet(int sid)
        {
            Betalings = Betaling.GetAllBetaling(sid);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Betaling.UpdateBetaling(Betalings);

            return RedirectToPage("/Payments/VisBetalings");
        }
    }
}