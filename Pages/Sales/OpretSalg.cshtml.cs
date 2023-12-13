using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Sales
{
    public class OpretSalgModel : PageModel
    {
        private ISalg salg;
        private IB�rn B�rn;

        public OpretSalgModel(ISalg salg, IB�rn b�rn)
        {
            this.salg = salg;
            B�rn = b�rn;
        }

        [BindProperty]

        public IEnumerable<B�rn> B�rns { get; set; }

        [BindProperty]

        public B�rn B�rnn { get; set; }

        [BindProperty]

        public Salg Salg { get; set; }



        public void OnGet()
        {
            //Lodseldler= lodseldler.GetAllodseldler(sid);
            B�rns = B�rn.GetB�rn();



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
