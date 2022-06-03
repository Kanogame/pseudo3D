using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pseudo3DCommon;

namespace Pseudo3D
{
    public class Player
    {
        private int x;
        private int y;
        private int angle;
        private RenderWindow window;

        public Player(RenderWindow window)
        {
            this.window = window;
        }

        private void DrawPlayer()
        {
            ObjectShape sh = new ObjectShape(x, y, 30, 20, false);
            window.Draw(sh.getCircleShape());
        }

        public void Forward()
        {

        }

        public void Back()
        {

        }

        public void Left()
        {

        }

        public void Right()
        {

        }
    }
}
