using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LiusStore.EntityFrameworkCore
{
    public static class LiusStoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LiusStoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LiusStoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
