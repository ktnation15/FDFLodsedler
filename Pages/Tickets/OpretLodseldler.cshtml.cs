using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Tickets
{
    public class OpretLodseldlerModel : PageModel
    {
        private ILodseldler lodseldler;
        private IBørn Børn;

        public OpretLodseldlerModel(ILodseldler lodseldler, IBørn børn)
        {
            this.lodseldler = lodseldler;
            Børn = børn;
        }

        [BindProperty]

        public IEnumerable<Børn> Børns { get; set; }

        [BindProperty]

        public Børn Børnn { get; set; }

        [BindProperty]

        public Lodseldler Lodseldler { get; set; }

       

        public void OnGet()
        {
            //Lodseldler= lodseldler.GetAllodseldler(sid);
            Børns = Børn.GetBørn();

            
            
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
