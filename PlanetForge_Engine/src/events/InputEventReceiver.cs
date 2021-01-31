using System.Collections.Generic;
using Silk.NET.Input;
using Silk.NET.Windowing;

namespace PlanetForge_Engine.events
{
    public class InputEventReceiver
    {
        public IReadOnlyList<IKeyboard> Keyboards => input.Keyboards;
        
        private readonly IInputContext input;
        private readonly IWindow window;

        public InputEventReceiver(IWindow window)
        {
            this.input = window.CreateInput();
            this.window = window;
            
            foreach (var t in input.Keyboards)
            {
                t.KeyDown += KeyDown;
            }
        }

        private void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        {
            //Check to close the window on escape.
            if (arg2 == Key.Escape)
            {
                window.Close();
            }
        }
    }
}