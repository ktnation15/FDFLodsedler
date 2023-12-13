using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace FDFLodsedler.Pages.Sales
{
    [Authorize(Roles = "Amin")]
    public class VisSalgModel : PageModel
    {
        private ISalg Salg;

        public VisSalgModel(ISalg salg)
        {
            Salg = salg;
        }

        [BindProperty]

        public IEnumerable<Salg> Salgs { get; set; }





        public void OnGet()
        {
            Salgs = Salg.GetSalg();
        }
    }
}
