using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class VisGruppeModel : PageModel
    {
        private IBørneGruppe børneGruppe;

        [BindProperty]

        public  IEnumerable<BørneGruppe>  børneGruppes{ get; set; }

        public VisGruppeModel(IBørneGruppe børneGruppe)
        {
            this.børneGruppe = børneGruppe;
        }

        public void OnGet()
        {
            børneGruppes=børneGruppe.GetBørn();
        }
    }
}
