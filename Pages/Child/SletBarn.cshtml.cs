using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{
    public class SletBarnModel : PageModel
    {
        private IBørn Børn;

      
        [BindProperty]
        public Børn børn { get; set; }


    public SletBarnModel(IBørn børn)
    {
        Børn = børn;
    }

    public void OnGet(int sid)
    {

        børn = Børn.GetAllBørn(sid);
    }

    public IActionResult OnPost()
    {

        Børn.RemoveBørn(børn);

        return RedirectToPage("/Child/VisBarn");
    }
}
}