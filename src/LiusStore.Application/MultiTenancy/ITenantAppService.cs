using Abp.Application.Services;
using LiusStore.MultiTenancy.Dto;

namespace LiusStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

