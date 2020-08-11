using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace LiusStore.Tasks.Dto
{
    [AutoMapTo(typeof(Task))]
    public class CreateTaskInput
    {
        public int? AssignedPersonId { get; set; }

        [Required]
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("[CreateTaskInput > AssignedPersonId = {0}, Description = {1}]", AssignedPersonId, Description);
        }
    }
}