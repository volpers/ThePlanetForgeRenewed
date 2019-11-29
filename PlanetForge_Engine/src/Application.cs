using System;
using PlanetForge.events;
using PlanetForge.window;

namespace PlanetForge
{
    public class Application
    {
        public Application() {
            new GlfwContext(640, 480, new EventDispatcher(new WindowResizeEvent()));
        }

        public virtual void Run() {
           
        }

        

    }
}
