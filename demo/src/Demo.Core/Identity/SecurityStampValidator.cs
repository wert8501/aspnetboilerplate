using Abp.Authorization;
using Abp.Domain.Uow;
using Demo.Authorization.Roles;
using Demo.Authorization.Users;
using Demo.MultiTenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Demo.Identity;

public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
{
    public SecurityStampValidator(
        IOptions<SecurityStampValidatorOptions> options,
        SignInManager signInManager,
        ILoggerFactory loggerFactory,
        IUnitOfWorkManager unitOfWorkManager)
        : base(options, signInManager, loggerFactory, unitOfWorkManager)
    {
    }
}
