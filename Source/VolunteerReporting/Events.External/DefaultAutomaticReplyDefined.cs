// CANNOT FIND THIS EVENT IN ANY BOUNDED CONTEXT
using Dolittle.Artifacts;
using Dolittle.Events;
using System;

namespace Events.External
{
    public class DefaultAutomaticReplyDefined : IEvent
    {
        public Guid Id { get; }
        public int Type { get; }
        public string Language { get; }
        public string Message { get; }
    }
}
