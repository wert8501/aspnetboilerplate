using Abp.Application.Services;
using Demo.MultiTenancy.Dto;

namespace Demo.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

