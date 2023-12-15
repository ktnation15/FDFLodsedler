using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{
    public class OpdatereBarnModel : PageModel
    {
        private IBørn Børn;

     
        public OpdatereBarnModel(IBørn børn)
        {
            Børn = børn;
        }

        [BindProperty]
        public Børn børn { get; set; }


    public void OnGet(int sid)
    {
        børn = Børn.GetAllBørn(sid);

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        Børn B = børn;
        Børn.Update(børn);


        return RedirectToPage("/Child/VisBarn");
    }
}
}