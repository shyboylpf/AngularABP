using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LiusStore.Configuration.Dto;

namespace LiusStore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LiusStoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
