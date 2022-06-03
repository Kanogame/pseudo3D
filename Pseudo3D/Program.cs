using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Pseudo3D
{
    public class Program
    {
        static RenderWindow window;
        static Player player;
        static World world;

        private static void intializeComponents()
        {
            world = new World(window);
            player = new Player();
        }

        static void Main(string[] args)
        {
            window = new RenderWindow(new VideoMode(800, 800), "test");
            intializeComponents();

            window.Closed += Window_Closed;
            window.Resized += Window_Resized;
            WindowIsOpen();
        }


        private static void WindowIsOpen()
        {
            int i = 0;
            while (window.IsOpen)
            {
                i++;
                world.DrawMap();
                window.DispatchEvents();
                window.KeyPressed += Window_KeyPressed;
                window.Display();
                if (i % 10000 == 0)
                {
                    window.SetTitle("test, fps: " + GetFps().ToString());
                    i = 0;
                }
            }
        }

        static float GetFps()
        {
            Clock clock = new Clock();
            float lastTime = 0;
            float currentTime = clock.Restart().AsSeconds();
            float fps = 1 / (currentTime - lastTime);
            lastTime = currentTime;
            return fps;
        }

        private static void Window_KeyPressed(object? sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.W)
            {
                player.Forward();
            }
            else if (e.Code == Keyboard.Key.S)
            {
                player.Back();
            }
            else if (e.Code == Keyboard.Key.A)
            {
                player.Left();
            }
            else if (e.Code == Keyboard.Key.D)
            {
                player.Right();
            }
        }

        private static void Window_Resized(object? sender, SizeEventArgs e)
        {
            window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height)));
        }

        private static void Window_Closed(object? sender, EventArgs e)
        {
            window.Close();
        }
    }
}