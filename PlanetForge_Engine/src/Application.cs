using PlanetForge_Engine.events;
using PlanetForge_Engine.window;

namespace PlanetForge_Engine
{
    public class Application
    {
        private GlfwContext glfwContext;

        public Application()
        {
            glfwContext = new GlfwContext(800, 600, new EventDispatcher(new WindowResizeEvent()));
        }

        public virtual void Run() {
           glfwContext.Start();
        }

        

    }
}
