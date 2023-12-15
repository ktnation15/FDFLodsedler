using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using FDFLodsedler.Pages.Child;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{

    public class OpretBarnModel : PageModel
    {

        private IB�rn B�rn;

        private IB�rneGruppe b�rneGruppe;
        [BindProperty]
        public B�rn b�rn { get; set; }
    [BindProperty]
    public IEnumerable<B�rneGruppe> B�rneGruppes { get; set; }

[BindProperty]

public B�rneGruppe B�rneGruppe { get; set; }

        public OpretBarnModel(IB�rn b�rn, IB�rneGruppe b�rneGruppe)
{
    B�rn = b�rn;
    this.b�rneGruppe = b�rneGruppe;
}

public void OnGet()
{
    B�rneGruppes = this.b�rneGruppe.GetB�rn();

}

public IActionResult OnPost()
{
    //if(!ModelState.IsValid)
    //{
    // return Page();
    //}
    B�rn.AddB�rn(b�rn);

    return RedirectToPage("/Child/VisBarn");
}
    }
}