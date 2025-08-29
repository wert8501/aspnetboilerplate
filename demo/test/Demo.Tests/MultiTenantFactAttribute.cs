using Xunit;

namespace Demo.Tests;

public sealed class MultiTenantFactAttribute : FactAttribute
{
    public MultiTenantFactAttribute()
    {
        if (!DemoConsts.MultiTenancyEnabled)
        {
            Skip = "MultiTenancy is disabled.";
        }
    }
}
