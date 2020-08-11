using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiusStore.Tasks
{
    [Table("AppPersons")]
    public class Person : Entity
    {
        public string Name { get; set; }
    }
}