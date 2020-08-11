﻿using Abp.EntityFrameworkCore;
using LiusStore.EntityFrameworkCore;
using LiusStore.EntityFrameworkCore.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiusStore.Tasks
{
    public class TaskRepository : LiusStoreRepositoryBase<Task, long>, ITaskRepository
    {
        public TaskRepository(IDbContextProvider<LiusStoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskState? state)
        {
            //In repository methods, we do not deal with create/dispose DB connections, DbContexes and transactions. ABP handles it.

            var query = GetAll(); //GetAll() returns IQueryable<T>, so we can query over it.
                                  //var query = Context.Tasks.AsQueryable(); //Alternatively, we can directly use EF's DbContext object.
                                  //var query = Table.AsQueryable(); //Another alternative: We can directly use 'Table' property instead of 'Context.Tasks', they are identical.

            //Add some Where conditions...

            if (assignedPersonId.HasValue)
            {
                query = query.Where(task => task.AssignedPerson.Id == assignedPersonId.Value);
            }

            if (state.HasValue)
            {
                query = query.Where(task => task.State == state);
            }

            return query
                .OrderByDescending(task => task.CreationTime)
                .Include(task => task.AssignedPerson) //Include assigned person in a single query
                .ToList();
        }
    }
}