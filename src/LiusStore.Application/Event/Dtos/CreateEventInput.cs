using System;

namespace LiusStore.Event.Dtos
{
    public class CreateEventInput
    {
        public string Title { get; internal set; }
        public DateTime Date { get; internal set; }
        public string Description { get; internal set; }
        public int MaxRegistrationCount { get; internal set; }
    }
}