using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Payments
{
    public class SletBetalingModel : PageModel
    {
        private IBetaling Betaling;
        [BindProperty]

        public Betaling betaling { get; set; }

        public SletBetalingModel(IBetaling betaling)
        {
            Betaling = betaling;
        }

        public void OnGet(int sid)
        {
            betaling = Betaling.GetAllBetaling(sid);
        }

        public IActionResult OnPost()
        {
            Betaling.RemoveBetaling(betaling);

            return RedirectToPage("/Payments/VisBetalings");

        }
    }
}