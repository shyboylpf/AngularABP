using Abp.Domain.Entities;

namespace LiusStore.Tasks
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }
    }
}