using Abp.Application.Services;
using LiusStore.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiusStore.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);

        void UpdateTask(UpdateTaskInput input);

        void CreateTask(CreateTaskInput input);
    }
}