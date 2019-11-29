using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGL;
using PlanetForge.events;
using GLFW;

namespace PlanetForge.window
{
    class GlfwContext    
    {
        private int _width = 640;
        public int Width {
            get { return _width; }            
            set {
                _width = value;
               // eventDispatcher.Dispatch<WindowResizeEvent>(e => { e.Width = _width; e.Height = _height; return true; });            
             } 
        }
        private int _height = 480;
        public int Height { 
            get { return _height; } 
            set { 
                _height = value;
               // eventDispatcher.Dispatch<WindowResizeEvent>(e => { e.Height = _height; e.Width = _width; return true; });
            } 
        }

        private Window _window;
        private EventDispatcher eventDispatcher;
        
        

        public GlfwContext(int width, int height, EventDispatcher eventDispatcher) 
        {
            Width = width;
            Height = height;
            this.eventDispatcher = eventDispatcher;
        }

        public void Start() {
            if (!Glfw.Init()) 
            {
                Environment.Exit(-1);
            }

            _window = Glfw.CreateWindow(_width, _height, "The PlanetForge", Monitor.None,Window.None);
            if (_window == null)
            {
                Glfw.Terminate();
                Environment.Exit(-1);
            }

            Glfw.MakeContextCurrent(_window);
            while (!Glfw.WindowShouldClose(_window)) {
                Gl.Clear(ClearBufferMask.ColorBufferBit);
                Glfw.SwapBuffers(_window);
                Glfw.PollEvents();
            }

            Glfw.Terminate();

        }
    }
}
