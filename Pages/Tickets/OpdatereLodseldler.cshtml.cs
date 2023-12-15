using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;

namespace FDFLodsedler.Pages.Tickets
{
    public class OpdatereLodseldlerModel : PageModel
    {

        private ILodseldler Lodseldler;

        [BindProperty]

        public Lodseldler lodseldler { get; set; }

        public OpdatereLodseldlerModel(ILodseldler lodseldler)
        {
            Lodseldler = lodseldler;
        }

        public void OnGet(int sid)
        {
            lodseldler = Lodseldler.GetAllodseldler(sid);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Lodseldler.Update(lodseldler);


            return RedirectToPage("/Tickets/VisLodseldler");
        }
    }
}