using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlanetForge;
using PlanetForge.utils;
using PlanetForge.events;

namespace Sandbox
{
    class SandboxApp : Application
    {
        static void Main(string[] args)
        {
            SandboxApp application = new SandboxApp();
            application.Run();
        }

        public override void Run()
        {
            KeyPressedEvent keyPressedEvent = new KeyPressedEvent(0, 0);
            EventDispatcher dispatcher = new EventDispatcher(keyPressedEvent);
            dispatcher.Dispatch<KeyPressedEvent>(e => { Console.WriteLine("BLAAAAAAAAAAA"); return true; });
            while (true) ;
        }
    }
}