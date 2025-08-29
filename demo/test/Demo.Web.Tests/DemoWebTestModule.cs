using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Demo.EntityFrameworkCore;
using Demo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Demo.Web.Tests;

[DependsOn(
    typeof(DemoWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class DemoWebTestModule : AbpModule
{
    public DemoWebTestModule(DemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(DemoWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(DemoWebMvcModule).Assembly);
    }
}