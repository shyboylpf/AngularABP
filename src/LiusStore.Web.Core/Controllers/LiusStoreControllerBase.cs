using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LiusStore.Controllers
{
    public abstract class LiusStoreControllerBase: AbpController
    {
        protected LiusStoreControllerBase()
        {
            LocalizationSourceName = LiusStoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
