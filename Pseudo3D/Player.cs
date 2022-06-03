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
        private double x = 100;
        private double y = 100;
        private int angle = 0;
        private RenderWindow window;

        public Player(RenderWindow window)
        {
            this.window = window;
        }

        public void DrawPlayer()
        {
            ObjectShape sh = new ObjectShape((int)x, (int)y, 30, 6, false);
            ObjectShape point = new ObjectShape((int)x, (int)y, 30, 5, true);
            window.Clear();
            var test = sh.getCircleShape();
            var pointer = point.getRectangleShape();
            test.Origin = new Vector2f(30, 30);
            pointer.Origin = new Vector2f(30, 30);
            test.Rotation = angle;
            pointer.Rotation = angle;
            window.Draw(test);
            window.Draw(pointer);
        }

        public void Forward()
        {
            x += 5 * Math.Cos(angle * Math.PI / 180);
            y += 5 * Math.Sin(angle * Math.PI / 180);
        }

        public void Back()
        {
            x -= 5 * Math.Cos(angle * Math.PI / 180);
            y -= 5 * Math.Sin(angle * Math.PI / 180);
        }

        public void Left()
        {
            if (angle >= 360)
            {
                angle = 0;
            }else
            {
                angle += 5;
            }
        }

        public void Right()
        {
            if (angle >= 360)
            {
                angle = 0;
            }
            else
            {
                angle -= 5;
            }
        }
    }
}
