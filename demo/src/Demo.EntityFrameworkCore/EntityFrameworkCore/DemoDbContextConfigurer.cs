using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Demo.EntityFrameworkCore;

public static class DemoDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<DemoDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<DemoDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
