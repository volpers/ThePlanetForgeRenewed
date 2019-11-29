using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetForge.events
{
    public class KeyEvent : Event
    {

        public int KeyCode { get; protected set; }

        protected KeyEvent(int keyCode)
        {
            this.CategoryFlags = EventCategory.Keyboard.Value() | EventCategory.Input.Value();
            this.KeyCode = keyCode;
        }
    }

    public class KeyPressedEvent : KeyEvent {

        public int RepeatCount { get; }      
      

        public KeyPressedEvent(int keyCode, int repeatCount) : base(keyCode)
        {
            this.RepeatCount = repeatCount;
            this.Type = EventType.KeyPressed;
            this.Name = EventType.KeyPressed.ToString();
        }

        public override string ToString()
        {
            return "KeyPressedEvent: " + KeyCode + "(" + RepeatCount + "repeats)";
        }


    }

}
