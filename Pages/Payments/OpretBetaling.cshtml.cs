using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using FDFLodsedler.Pages.Payments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace FDFLodsedler.Pages.Payments
{
    public class OpretBetalingModel : PageModel
    {
        private IBørn Børn;

        private IBetaling Betaling;
        [BindProperty]

        public Betaling Betalings { get; set; }
        public Børn børn { get; set; }
    [BindProperty]
    public IEnumerable<Børn> Børne { get; set; }

[BindProperty]

public Børn Børns { get; set; }

        

        public OpretBetalingModel(IBetaling betaling, IBørn børn)
{
    Betaling = betaling;
    Børn = børn;
}

public void OnGet()
{
    Børne = Børn.GetBørn();

}

public IActionResult OnPost()
{
    //if(!ModelState.IsValid)
    //{
    // return Page();
    //}
    Betaling.AddBetaling(Betalings);

    return RedirectToPage("/Payments/VisBetalings");
}
    }
}