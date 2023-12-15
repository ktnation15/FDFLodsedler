using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Payments
{
    public class VisBetalingsModel : PageModel
    {
        private IBetaling Betailing;
        [BindProperty]

        public IEnumerable<Betaling> betalings { get; set; }

        public VisBetalingsModel(IBetaling betailing)
        {
            Betailing = betailing;
        }

        public void OnGet()
        {
            betalings = Betailing.GetBetaling();
        }
    }
}