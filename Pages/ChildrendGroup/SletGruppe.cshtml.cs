using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class SletGruppeModel : PageModel
    {
        private IB�rneGruppe B�rnGruppe;

        public SletGruppeModel(IB�rneGruppe b�rnGruppe)
        {
            B�rnGruppe = b�rnGruppe;
        }

        [BindProperty]
        public B�rneGruppe b�rneGruppe { get; set; }




    public void OnGet(int sid)
    {

        b�rneGruppe = B�rnGruppe.GetAllB�rn(sid);
    }

    public IActionResult OnPost()
    {

        B�rnGruppe.RemoveB�rneGruppe(b�rneGruppe);

        return RedirectToPage("/ChildrendGroup/VisGruppe");
    }
}
}