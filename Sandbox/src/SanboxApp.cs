using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlanetForge;

namespace Sandbox
{
    class SandboxApp : Application
    {
        static void Main(string[] args)
        {
            SandboxApp application = new SandboxApp();
            Console.WriteLine("Hello World!");
            application.Run();
        }

        public override void Run()
        {
            while (true) ;
        }
    }
}
