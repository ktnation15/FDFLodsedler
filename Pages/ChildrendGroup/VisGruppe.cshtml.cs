using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class VisGruppeModel : PageModel
    {
        private IB�rneGruppe b�rneGruppe;

        [BindProperty]

        public IEnumerable<B�rneGruppe> b�rneGruppes{ get; set; }

    public VisGruppeModel(IB�rneGruppe b�rneGruppe)
    {
        this.b�rneGruppe = b�rneGruppe;
    }

    public void OnGet()
    {
        b�rneGruppes = b�rneGruppe.GetB�rn();
    }
}
}