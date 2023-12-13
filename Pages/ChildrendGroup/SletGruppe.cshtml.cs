using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class SletGruppeModel : PageModel
    {
        private IBørneGruppe BørnGruppe;

        public SletGruppeModel(IBørneGruppe børnGruppe)
        {
            BørnGruppe = børnGruppe;
        }

        [BindProperty]
        public BørneGruppe børneGruppe { get; set; }


        

        public void OnGet(int sid)
        {

            børneGruppe = BørnGruppe.GetAllBørn(sid);
        }

        public IActionResult OnPost()
        {

            BørnGruppe.RemoveBørneGruppe(børneGruppe);

            return RedirectToPage("/ChildrendGroup/VisGruppe");
        }
    }
}
