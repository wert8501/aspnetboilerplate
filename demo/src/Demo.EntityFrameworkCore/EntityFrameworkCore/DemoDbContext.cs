using Abp.Zero.EntityFrameworkCore;
using Demo.Authorization.Roles;
using Demo.Authorization.Users;
using Demo.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFrameworkCore;

public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
{
    /* Define a DbSet for each entity of the application */

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }
}
