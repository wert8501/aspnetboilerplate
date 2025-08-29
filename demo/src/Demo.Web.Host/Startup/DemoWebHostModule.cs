using Abp.Modules;
using Abp.Reflection.Extensions;
using Demo.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Demo.Web.Host.Startup
{
    [DependsOn(
       typeof(DemoWebCoreModule))]
    public class DemoWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoWebHostModule).GetAssembly());
        }
    }
}
