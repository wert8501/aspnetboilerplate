using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Demo.Authorization.Users;
using Demo.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Demo;

/// <summary>
/// Derive your application services from this class.
/// </summary>
public abstract class DemoAppServiceBase : ApplicationService
{
    public TenantManager TenantManager { get; set; }

    public UserManager UserManager { get; set; }

    protected DemoAppServiceBase()
    {
        LocalizationSourceName = DemoConsts.LocalizationSourceName;
    }

    protected virtual async Task<User> GetCurrentUserAsync()
    {
        var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
        if (user == null)
        {
            throw new Exception("There is no current user!");
        }

        return user;
    }

    protected virtual Task<Tenant> GetCurrentTenantAsync()
    {
        return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
    }

    protected virtual void CheckErrors(IdentityResult identityResult)
    {
        identityResult.CheckErrors(LocalizationManager);
    }
}
