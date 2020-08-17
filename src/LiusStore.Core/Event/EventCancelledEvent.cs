using Abp.Events.Bus;
using System;

namespace LiusStore.Event
{
    public class EventCancelledEvent : IEventData
    {
        private Event @event;

        public EventCancelledEvent(Event @event)
        {
            this.@event = @event;
        }

        public Event Entity { get; internal set; }
        public DateTime EventTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object EventSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}