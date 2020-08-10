using System.Threading.Tasks;
using Abp.Application.Services;
using LiusStore.Sessions.Dto;

namespace LiusStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
