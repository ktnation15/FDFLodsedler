using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace FDFLodsedler.Pages.Board
{
    [Authorize(Roles = "Amin")]
    public class VisMedlemmerModel : PageModel
    {
        private IBestyrelse Bestyrelse;

        public VisMedlemmerModel(IBestyrelse bestyrelse)
        {
            Bestyrelse = bestyrelse;
        }

        [BindProperty]

        public IEnumerable<Bestyrelse> bestyrelses { get; set; }





        public void OnGet()
        {
            bestyrelses = Bestyrelse.GetMedlemmer();
        }
    }
}
