using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class OpdatereGruppeModel : PageModel
    {
        private IBørneGruppe børneGruppe;

        public OpdatereGruppeModel(IBørneGruppe børneGruppe)
        {
            this.børneGruppe = børneGruppe;
        }

        [BindProperty]
        public BørneGruppe BørneGruppe { get; set; }


    public void OnGet(int sid)
    {
        BørneGruppe = børneGruppe.GetAllBørn(sid);

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        børneGruppe.Update(BørneGruppe);


        return RedirectToPage("/ChildrendGroup/VisGruppe");
    }
}
}