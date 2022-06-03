using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pseudo3DCommon;
using SFML.System;

namespace Pseudo3D
{
    public class Player
    {
        private int x = 100;
        private int y = 100;
        private int angle = 0;
        private RenderWindow window;

        public Player(RenderWindow window)
        {
            this.window = window;
        }

        public void DrawPlayer()
        {
            ObjectShape sh = new ObjectShape(x, y, 30, 6, false);
            ObjectShape point = new ObjectShape(x + 23, y, 10, 5, true);
            window.Clear();
            var test = sh.getCircleShape();
            var pointer = point.getRectangleShape();
            test.Origin = new Vector2f(30, 30);
            pointer.Origin = new Vector2f(30 + 23, 30);
            test.Rotation = angle;
            pointer.Rotation = angle;
            window.Draw(test);
            window.Draw(pointer);
        }

        public void Forward()
        {
            x = x + (5 + 5 * (angle / 100));
            y = y + (5 + ((angle - (angle / 2)) / 100));
        }

        public void Back()
        {
            x = x - (5 * (angle / 100));
            y = y - (5 * ((angle - (angle / 2)) / 100));
        }

        public void Left()
        {
            angle += 5;
        }

        public void Right()
        {
            angle -= 5;
        }
    }
}
