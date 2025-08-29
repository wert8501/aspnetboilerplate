using Abp.Application.Services;
using Demo.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace Demo.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
