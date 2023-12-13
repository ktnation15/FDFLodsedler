using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Sales
{
    public class OpretSalgModel : PageModel
    {
        private ISalg salg;
        private IBørn Børn;

        public OpretSalgModel(ISalg salg, IBørn børn)
        {
            this.salg = salg;
            Børn = børn;
        }

        [BindProperty]

        public IEnumerable<Børn> Børns { get; set; }

        [BindProperty]

        public Børn Børnn { get; set; }

        [BindProperty]

        public Salg Salg { get; set; }



        public void OnGet()
        {
            //Lodseldler= lodseldler.GetAllodseldler(sid);
            Børns = Børn.GetBørn();



        }

        public IActionResult OnPost()

        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();

            //}
            salg.AddSalg(Salg);

            return RedirectToPage("/Sales/VisSalg");

        }
    }
}
