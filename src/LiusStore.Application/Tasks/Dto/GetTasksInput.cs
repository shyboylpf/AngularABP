using Abp.AutoMapper;

namespace LiusStore.Tasks.Dto
{
    [AutoMapTo(typeof(Task))]
    public class GetTasksInput
    {
        public int? AssignedPersonId { get; set; }
        public TaskState? State { get; set; }
    }
}