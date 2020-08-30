using Convey.CQRS.Events;

namespace operations.api.types
{
    public class RejectedEvent : IRejectedEvent, IMessage
    {
        public string Reason { get; set; }
        public string Code { get; set; }
    }
}