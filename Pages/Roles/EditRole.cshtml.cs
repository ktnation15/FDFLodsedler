using FDFLodsedler.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Roles
{
    public class EditRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;


        public EditRoleModel(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [BindProperty]
        public EditRole EditRole { get; set; }

        [BindProperty]

        public string RoleName { get; set; }

        public string Id { get; set; }


        public async Task<IActionResult> OnGetAsync(string sid)
        {
            var existingRole = roleManager.Roles.FirstOrDefault(r => r.Id == sid);

            if (existingRole == null)
            {
                // Handle the case where the role doesn't exist
                return RedirectToPage("/NotFound"); // Replace with your actual NotFound page or logic
            }

            EditRole = new EditRole { RoleName = existingRole.Name, Id = existingRole.Id };

            var usersList = userManager.Users.ToList();

            foreach (var user in usersList)
            {
                if (await userManager.IsInRoleAsync(user, EditRole.RoleName))
                {
                    EditRole.Users.Add(user.Email);
                }
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {



            var existingRole = await roleManager.FindByIdAsync(EditRole.Id);


            if (existingRole == null)
            {
                // Handle the case where the role doesn't exist
                return RedirectToPage("/NotFound"); // Replace with your actual NotFound page or logic
            }

            existingRole.Name = EditRole.RoleName;

            var result = await roleManager.UpdateAsync(existingRole);

            if (result.Succeeded)
            {
                return RedirectToPage("/Roles/GetRoles"); // Replace with your actual success page or logic
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }


            return Page();

        }

    }
}
