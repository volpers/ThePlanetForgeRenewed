using System;
using System.Collections.Generic;
using System.Text;
using PlanetForge.utils;

namespace PlanetForge.events
{
   public enum EventType {
        None, WindowClose, WindowResize, WindowFocus, WindowLostFocus, WindowMoved,
        AppTick, AppUpdate, AppRender,
        KeyPressed, KeyReleased, KeyTyped,
        MouseButtonPressed, MouseButtonReleased, MouseMoved, MouseScrolled
    }

    public static class EventCategoryExtensions {
        public static int Value(this EventCategory e) {
            return (int)e;
        }
    }

    public enum EventCategory {
        None = 0,
        Application = 1 << 1,
        Input = 1 << 2,
        Keyboard = 1 << 3,
        Mouse = 1 << 4,
        MouseButton = 1 << 5
}

    public abstract class Event
    {
        public EventType Type { get; protected set; }
        public string Name { get; protected set; } 
        public int CategoryFlags { get; protected set; }

        public bool Handled{set; get;}

        public bool IsInCategory(EventCategory category)
        {
           return (CategoryFlags & (category.Value())) != 0;
        }

        public override string ToString()
        {
            return Name;
        }       


    }
}
