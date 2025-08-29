using Abp.AutoMapper;
using Demo.Sessions.Dto;

namespace Demo.Web.Views.Shared.Components.TenantChange;

[AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
public class TenantChangeViewModel
{
    public TenantLoginInfoDto Tenant { get; set; }
}
