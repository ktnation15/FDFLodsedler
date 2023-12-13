using FDFLodsedler.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Roles
{
    public class GetRolesModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public IEnumerable<CreateRole> Roles { get; set; }

        public GetRolesModel(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public void OnGet()
        {
            //Roles= (IEnumerable<CreateRole>)roleManager.Roles;
            Roles = roleManager.Roles.Select(r => new CreateRole { RoleName = r.Name, RoleId = r.Id });
        }
    }
}
