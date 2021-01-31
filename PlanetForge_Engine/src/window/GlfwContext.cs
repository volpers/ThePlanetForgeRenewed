using System;
using PlanetForge_Engine.events;
using Silk.NET.GLFW;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace PlanetForge_Engine.window
{
    class GlfwContext    
    {
        private int width = 640;
        public int Width {
            get { return width; }            
            set {
                width = value;
               // eventDispatcher.Dispatch<WindowResizeEvent>(e => { e.Width = _width; e.Height = _height; return true; });            
             } 
        }
        private int height = 480;
        public int Height { 
            get { return height; } 
            set { 
                height = value;
               // eventDispatcher.Dispatch<WindowResizeEvent>(e => { e.Height = _height; e.Width = _width; return true; });
            } 
        }

        private IWindow window;
        private EventDispatcher eventDispatcher;
        private InputEventReceiver eventReceiver;


        public GlfwContext(int width, int height, EventDispatcher eventDispatcher) 
        {
            Width = width;
            Height = height;
            this.eventDispatcher = eventDispatcher;
        }

        public void Start() {
            //Create a window.
            var options = WindowOptions.Default;
            options.Size = new Vector2D<int>(width, height);
            options.Title = "The Planet Forge";

            window = Window.Create(options);

            //Assign events.
            window.Load += OnLoad;
            window.Update += OnUpdate;
            window.Render += OnRender;
            window.Run();
            
            // if (!Glfw.Init()) 
            // {
            //     Environment.Exit(-1);
            // }
            //
            // _window = Glfw.CreateWindow(_width, _height, "The PlanetForge", Monitor.None,Window.None);
            // if (_window == null)
            // {
            //     Glfw.Terminate();
            //     Environment.Exit(-1);
            // }
            //
            // Glfw.MakeContextCurrent(_window);
            // while (!Glfw.WindowShouldClose(_window)) {
            //     Gl.Clear(ClearBufferMask.ColorBufferBit);
            //     Glfw.SwapBuffers(_window);
            //     Glfw.PollEvents();
            // }
            //
            // Glfw.Terminate();

        }
        
        
        private void OnLoad()
        {
            eventReceiver = new InputEventReceiver(window);
        }

        private void OnRender(double obj)
        {
            //Here all rendering should be done.
        }

        private void OnUpdate(double obj)
        {
            //Here all updates to the program should be done.
        }

    }
}
