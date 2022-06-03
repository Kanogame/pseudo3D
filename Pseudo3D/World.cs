using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Pseudo3D
{
    public class World
    {
        private RenderWindow window;
        public Shape shape;

        public World(RenderWindow window)
        {
            this.window = window;
            shape = new Shape();
        }

        public void DrawMap()
        {
            CircleShape circle = shape.getCircleShape(10, 10, 100, 10, true);
            window.Draw(circle);

            RectangleShape rect1 = shape.getRectangleShape(300, 200, 100, 200, true);
            window.Draw(rect1);

            RectangleShape rect2 = shape.getRectangleShape(500, 200, 80, 100, true);
            window.Draw(rect2);

            RectangleShape rect3 = shape.getRectangleShape(500, 500, 200, 200, true);
            window.Draw(rect3);

            CircleShape Triangle = shape.getCircleShape(50, 400, 50, 3, true);
            window.Draw(Triangle);
        }
    }
}
