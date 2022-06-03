using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using Pseudo3DCommon;

namespace Pseudo3D
{
    public class World
    {
        private RenderWindow window;

        public World(RenderWindow window)
        {
            this.window = window;
        }

        public void DrawMap()
        {
            ObjectShape circle = new ObjectShape(10, 10, 100, 10, true);
            //window.Draw(circle.getCircleShape());

            ObjectShape rect1 = new ObjectShape(300, 200, 100, 200, true);
            window.Draw(rect1.getRectangleShape());

            ObjectShape rect2 = new ObjectShape(500, 200, 80, 100, true);
            window.Draw(rect2.getRectangleShape());

            ObjectShape rect3 = new ObjectShape(500, 500, 200, 200, true);
            window.Draw(rect3.getRectangleShape());

            ObjectShape Triangle = new ObjectShape(50, 400, 50, 3, true);
            window.Draw(Triangle.getCircleShape());
        }
    }
}
