using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace LiusStore.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }
        public int? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }
    }
}