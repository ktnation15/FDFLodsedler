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
        private IB�rn B�rn;

        private IBetaling Betaling;
        [BindProperty]

        public Betaling Betalings { get; set; }
        public B�rn b�rn { get; set; }
    [BindProperty]
    public IEnumerable<B�rn> B�rne { get; set; }

[BindProperty]

public B�rn B�rns { get; set; }

        

        public OpretBetalingModel(IBetaling betaling, IB�rn b�rn)
{
    Betaling = betaling;
    B�rn = b�rn;
}

public void OnGet()
{
    B�rne = B�rn.GetB�rn();

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