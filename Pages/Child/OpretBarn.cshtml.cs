using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using FDFLodsedler.Pages.Child;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{

    public class OpretBarnModel : PageModel
    {

        private IBørn Børn;

        private IBørneGruppe børneGruppe;
        [BindProperty]
        public Børn børn { get; set; }
    [BindProperty]
    public IEnumerable<BørneGruppe> BørneGruppes { get; set; }

[BindProperty]

public BørneGruppe BørneGruppe { get; set; }

        public OpretBarnModel(IBørn børn, IBørneGruppe børneGruppe)
{
    Børn = børn;
    this.børneGruppe = børneGruppe;
}

public void OnGet()
{
    BørneGruppes = this.børneGruppe.GetBørn();

}

public IActionResult OnPost()
{
    //if(!ModelState.IsValid)
    //{
    // return Page();
    //}
    Børn.AddBørn(børn);

    return RedirectToPage("/Child/VisBarn");
}
    }
}