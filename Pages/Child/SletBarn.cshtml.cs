using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{
    public class SletBarnModel : PageModel
    {
        private IB�rn B�rn;

      
        [BindProperty]
        public B�rn b�rn { get; set; }


    public SletBarnModel(IB�rn b�rn)
    {
        B�rn = b�rn;
    }

    public void OnGet(int sid)
    {

        b�rn = B�rn.GetAllB�rn(sid);
    }

    public IActionResult OnPost()
    {

        B�rn.RemoveB�rn(b�rn);

        return RedirectToPage("/Child/VisBarn");
    }
}
}