using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetForge.events
{
    public delegate bool EventAction<T>(T e) where T : Event;

    public class EventDispatcher
    {
        private Event _event;
        
       
        public EventDispatcher(Event e) {
            _event = e;
        }

        public void Dispatch<T>(EventAction<T> eventAction) where T : Event {
            _event.Handled = eventAction(_event as T);
        }
    }
}
