using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.ChildrendGroup
{
    public class OpretGruppeModel : PageModel
    {

        private IBørneGruppe BørneGruppe;

        private Ileder Ileder;

        [BindProperty]

        public IEnumerable<Leder> Leder { get; set; }

        [BindProperty]

        public BørneGruppe børneGruppe { get; set; }

        public OpretGruppeModel(IBørneGruppe børneGruppe, Ileder ileder)
        {
            BørneGruppe = børneGruppe;
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
            BørneGruppe.AddBørneGrupppe(børneGruppe);

            return RedirectToPage("/ChildrendGroup/VisGruppe");
        
        }

    }
}
