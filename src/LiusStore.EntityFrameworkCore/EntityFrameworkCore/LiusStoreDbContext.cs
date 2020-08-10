using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LiusStore.Authorization.Roles;
using LiusStore.Authorization.Users;
using LiusStore.MultiTenancy;
using LiusStore.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiusStore.EntityFrameworkCore
{
    public class LiusStoreDbContext : AbpZeroDbContext<Tenant, Role, User, LiusStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }

        public LiusStoreDbContext(DbContextOptions<LiusStoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<User>();
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Isaac Asimov" },
                new Person { Id = 2, Name = "Thomas More" },
                new Person { Id = 3, Name = "George Orwell" },
                new Person { Id = 4, Name = "Douglas Adams" }
                );
        }
    }
}