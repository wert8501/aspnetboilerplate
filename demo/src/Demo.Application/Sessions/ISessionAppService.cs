using Abp.Application.Services;
using Demo.Sessions.Dto;
using System.Threading.Tasks;

namespace Demo.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
