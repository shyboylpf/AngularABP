using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiusStore.EntityFrameworkCore
{
    public class IDbSet<T> : DbSet<Entity>
    {
    }
}