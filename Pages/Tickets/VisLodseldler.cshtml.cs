using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace FDFLodsedler.Pages.Tickets
{
    [Authorize(Roles = "Amin")]
    public class VisLodseldlerModel : PageModel
    {
        private ILodseldler lodseldler;

        public VisLodseldlerModel(ILodseldler lodseldler)
        {
            this.lodseldler = lodseldler;
        }

        [BindProperty]

        public IEnumerable<Lodseldler> Lodseldler { get; set; }



        

        public void OnGet()
        {
            Lodseldler = lodseldler.Getlodseldler();
        }
    }
}
