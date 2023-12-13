using FDFLodsedler.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Roles
{
    public class UserRoleModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;



        public UserRoleModel(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        [BindProperty]
        public List<UserRole> UsersInRole { get; set; }

        [BindProperty]

       

        public UserRole UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(string sid)
        {



            var role = await roleManager.FindByIdAsync(sid);
            if (role == null)
            {
                return NotFound();
            }

            UsersInRole = new List<UserRole>();
            var usersList = userManager.Users.ToList();

            foreach (var user in usersList)
            {
                //UserRole = new UserRole
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    UserName = user.UserName,

                };
                

                userRole.IsSelected = await userManager.IsInRoleAsync(user, role.Name);

                UsersInRole.Add(userRole);
            }

            return Page();


        }
        public async Task<IActionResult> OnPostAsync(string sid)
        {
            var role = await roleManager.FindByIdAsync(sid);

            if (role == null)
            {
                return NotFound();
            }

            foreach (var userRole in UsersInRole)
            {
                var user = await userManager.FindByIdAsync(userRole.UserId);



                if (userRole.IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    var result = await userManager.AddToRoleAsync(user, role.Name);

                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("", "Failed to add user to role.");
                    }
                }
                else if (!userRole.IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    var result = await userManager.RemoveFromRoleAsync(user, role.Name);

                    if (!result.Succeeded)
                    {
                        ModelState.AddModelError("", "Failed to remove user from role.");
                    }
                }
            }

            //if (!ModelState.IsValid)
            //    {

            //        return Page();
            //    }

            return RedirectToPage("/Roles/EditRole", new { sid });



        }

    }
}
