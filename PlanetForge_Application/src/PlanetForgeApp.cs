using PlanetForge_Engine;
using PlanetForge_Engine.events;
using PlanetForge_Engine.utils;

namespace PlanetForge_Application
{
    class PlanetForgeApp : Application
    {
        static void Main(string[] args)
        {
            PlanetForgeApp application = new PlanetForgeApp();
            application.Run();
        }

        public override void Run()
        {
            base.Run();
            var keyPressedEvent = new KeyPressedEvent(0, 0);
            var dispatcher = new EventDispatcher(keyPressedEvent);
            dispatcher.Dispatch<KeyPressedEvent>(e => {
                Logger.Info("Info");
                Logger.Trace("Trace");
                Logger.Error("Error");
                Logger.Warn("Warn");                
                return true; }      
             );
            // while (true) ;
        }
    }
}