using System.Collections.Generic;
using Silk.NET.Input;

namespace PlanetForge_Engine.events
{
    public delegate bool EventAction<T>(T e) where T : Event;

    public class EventDispatcher
    {
        private Event @event;
       
        
        public EventDispatcher(Event e) {
            @event = e;
        }

        public void Dispatch<T>(EventAction<T> eventAction) where T : Event {
            @event.Handled = eventAction(@event as T);
        }
    }
}
