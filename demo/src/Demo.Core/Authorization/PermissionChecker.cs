using Abp.Authorization;
using Demo.Authorization.Roles;
using Demo.Authorization.Users;

namespace Demo.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
