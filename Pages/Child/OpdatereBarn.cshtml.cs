using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{
    public class OpdatereBarnModel : PageModel
    {
        private IB�rn B�rn;

     
        public OpdatereBarnModel(IB�rn b�rn)
        {
            B�rn = b�rn;
        }

        [BindProperty]
        public B�rn b�rn { get; set; }


    public void OnGet(int sid)
    {
        b�rn = B�rn.GetAllB�rn(sid);

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        B�rn B = b�rn;
        B�rn.Update(b�rn);


        return RedirectToPage("/Child/VisBarn");
    }
}
}