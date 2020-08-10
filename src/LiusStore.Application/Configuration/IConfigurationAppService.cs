using System.Threading.Tasks;
using LiusStore.Configuration.Dto;

namespace LiusStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
