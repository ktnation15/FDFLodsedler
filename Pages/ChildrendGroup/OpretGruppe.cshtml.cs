using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class OpretGruppeModel : PageModel
    {

        private IB�rneGruppe B�rneGruppe;

        private Ileder Ileder;

        [BindProperty]

        public IEnumerable<Leder> Leder { get; set; }

        [BindProperty]

        public B�rneGruppe b�rneGruppe { get; set; }

        public OpretGruppeModel(IB�rneGruppe b�rneGruppe, Ileder ileder)
        {
            B�rneGruppe = b�rneGruppe;
            Ileder = ileder;
        }

        public void OnGet()
        {
            if (Leder == null)
                Leder = Ileder.GetLeder();
        }

        public IActionResult OnPost()
        {

            if(!ModelState.IsValid)
            {
                return Page();
            }
            B�rneGruppe.AddB�rneGrupppe(b�rneGruppe);

            return RedirectToPage("/ChildrendGroup/VisGruppe");
        
        }

    }
}
