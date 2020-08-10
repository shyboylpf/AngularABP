using System.Threading.Tasks;
using Abp.Application.Services;
using LiusStore.Authorization.Accounts.Dto;

namespace LiusStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
