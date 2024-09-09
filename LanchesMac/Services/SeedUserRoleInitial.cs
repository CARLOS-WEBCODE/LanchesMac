using Microsoft.AspNetCore.Identity;

namespace LanchesMac.Services;

public class SeedUserRoleInitial : ISeedUserRoleInitial
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public SeedUserRoleInitial(UserManager<IdentityUser> userManager, 
        RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public void SeedRoles()
    {
        throw new NotImplementedException();
    }

    public void SeedUsers()
    {
        throw new NotImplementedException();
    }
}
