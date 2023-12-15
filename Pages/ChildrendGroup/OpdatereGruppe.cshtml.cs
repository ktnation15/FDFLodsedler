using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class OpdatereGruppeModel : PageModel
    {
        private IB�rneGruppe b�rneGruppe;

        public OpdatereGruppeModel(IB�rneGruppe b�rneGruppe)
        {
            this.b�rneGruppe = b�rneGruppe;
        }

        [BindProperty]
        public B�rneGruppe B�rneGruppe { get; set; }


    public void OnGet(int sid)
    {
        B�rneGruppe = b�rneGruppe.GetAllB�rn(sid);

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        b�rneGruppe.Update(B�rneGruppe);


        return RedirectToPage("/ChildrendGroup/VisGruppe");
    }
}
}