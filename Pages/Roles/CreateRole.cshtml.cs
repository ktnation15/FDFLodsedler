using FDFLodsedler.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Roles
{
    public class CreateRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleManager;

        [BindProperty]
        public CreateRole CreateRole { get; set; }
        public CreateRoleModel(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public void OnGet()
        {


        }
        public async Task<IActionResult> OnPostAsync()
        {

            IdentityRole role = new IdentityRole
            {
                Name = CreateRole.RoleName
            };
            IdentityResult result = await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToPage("/Roles/GetRoles");
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);

            }



            return Page();


        }


    }
}
