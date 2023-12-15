using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Tickets
{
    public class SletLodselderModel : PageModel
    {
        private ILodseldler lodseldler;

        public SletLodselderModel(ILodseldler lodseldler)
        {
            this.lodseldler = lodseldler;
        }



        [BindProperty]
        public Lodseldler Lodseldler { get; set; }




        public void OnGet(int sid)
        {

            Lodseldler = lodseldler.GetAllodseldler(sid);
        }

        public IActionResult OnPost()
        {

            lodseldler.Removelodsseldler(Lodseldler);

            return RedirectToPage("/Tickets/VisLodseldler");
        }
    }
}