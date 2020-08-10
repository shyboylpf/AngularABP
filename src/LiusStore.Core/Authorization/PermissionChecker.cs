using Abp.Authorization;
using LiusStore.Authorization.Roles;
using LiusStore.Authorization.Users;

namespace LiusStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
