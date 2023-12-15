using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Tickets
{
    public class OpretLodseldlerModel : PageModel
    {
        private ILodseldler lodseldler;
        private IB�rn B�rn;

        public OpretLodseldlerModel(ILodseldler lodseldler, IB�rn b�rn)
        {
            this.lodseldler = lodseldler;
            B�rn = b�rn;
        }

        [BindProperty]

        public IEnumerable<B�rn> B�rns { get; set; }

    [BindProperty]

    public B�rn B�rnn { get; set; }

[BindProperty]

public Lodseldler Lodseldler { get; set; }



public void OnGet()
{
    //Lodseldler= lodseldler.GetAllodseldler(sid);
    B�rns = B�rn.GetB�rn();



}

public IActionResult OnPost()

{
    //if (!ModelState.IsValid)
    //{
    //    return Page();

    //}
    lodseldler.Addlodseldler(Lodseldler);

    return RedirectToPage("/Tickets/VisLodseldler");

}
    }
}