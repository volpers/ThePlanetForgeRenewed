namespace PlanetForge_Engine.events
{
    class WindowResizeEvent : Event 
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public WindowResizeEvent() {
            this.Type = EventType.WindowResize;
            this.CategoryFlags = EventCategory.Application.Value();
        }

        public override string ToString()
        {
            return "WindowResizeEvent: " + Width + ", " + Height;
        }
    }

    class WindowCloseEvent : Event 
    {
        public WindowCloseEvent() 
        {
            this.Type = EventType.WindowClose;
            this.CategoryFlags = EventCategory.Application.Value();
        }
    }

    class AppTickEvent : Event 
    {
        public AppTickEvent() 
        {
            this.Type = EventType.AppTick;
            this.CategoryFlags = EventCategory.Application.Value();
        }
    }

    class AppUpdateEvent : Event 
    {
        public AppUpdateEvent() 
        {
            this.Type = EventType.AppUpdate;
            this.CategoryFlags = EventCategory.Application.Value();
        }
    }

    class AppRenderEvent : Event
    {
        public AppRenderEvent() 
        {
            this.Type = EventType.AppRender;
            this.CategoryFlags = EventCategory.Application.Value();
        }
    }
}
