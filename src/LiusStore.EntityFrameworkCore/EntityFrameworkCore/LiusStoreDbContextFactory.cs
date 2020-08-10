using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LiusStore.Configuration;
using LiusStore.Web;

namespace LiusStore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LiusStoreDbContextFactory : IDesignTimeDbContextFactory<LiusStoreDbContext>
    {
        public LiusStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LiusStoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LiusStoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LiusStoreConsts.ConnectionStringName));

            return new LiusStoreDbContext(builder.Options);
        }
    }
}
