using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LiusStore.Tasks
{
    [Table("AppTasks")]
    public class Task : Entity<long>
    {
        [ForeignKey(nameof(AssignedPersonId))]
        public Person AssignedPerson { get; set; }

        public int? AssignedPersonId { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }
    }
}