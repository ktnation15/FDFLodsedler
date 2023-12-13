using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Board
{
    public class AddMedlemmerModel : PageModel
    {
        private IBestyrelse Bestyrelse;

        public AddMedlemmerModel(IBestyrelse bestyrelse)
        {
            Bestyrelse = bestyrelse;
        }

        [BindProperty]
        public Bestyrelse bestyrelse { get; set; }
        
       

        public void OnGet()
        {
           

        }

        public IActionResult OnPost()
        {
            //if(!ModelState.IsValid)
            //{
            // return Page();
            //}
            Bestyrelse.AddMedlemmer(bestyrelse);

            return RedirectToPage("/Board/VisMedlemmer");
        }
    }
}
