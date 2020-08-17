using LiusStore.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiusStore.Event
{
    public interface IEventManager
    {
        public Task<Event> GetAsync(Guid id);

        public Task CreateAsync(Event @event);

        public void Cancel(Event @event);

        public Task<EventRegistration> RegisterAsync(Event @event, User user);

        public Task CancelRegistrationAsync(Event @event, User user);

        public Task<IReadOnlyList<User>> GetRegisteredUsersAsync(Event @event);
    }
}