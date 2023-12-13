using FDFLodsedler.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;


        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;

        }
        [BindProperty]
        public Login Login { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string? returnurl = null)
        {
            if (ModelState.IsValid)
            {
                var IdentityResult = await signInManager.PasswordSignInAsync(Login.Email, Login.Password, Login.RememberMe, false);
                if (IdentityResult.Succeeded)
                {
                    if (returnurl == null || returnurl == "/")
                    {
                        return RedirectToPage("/Index");
                    }

                    else
                    {
                        return RedirectToPage(returnurl);
                    }
                }

                ModelState.AddModelError("", "User Name or Password Incorrect");

            }
            return Page();
        }


    }
}
