using LiusStore.Authorization.Users;
using System.Threading.Tasks;

namespace LiusStore.Event
{
    public interface IEventRegistrationPolicy
    {
        public Task CheckRegistrationAttemptAsync(Event @event, User user);
    }
}