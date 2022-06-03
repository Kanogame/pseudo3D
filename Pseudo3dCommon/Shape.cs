using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudo3D
{
    public class Shape
    {
        public CircleShape getCircleShape(int x, int y, int radius, int points, bool outlines)
        {
            CircleShape circleShape = new CircleShape(radius, (uint)points);
            circleShape.Position = new Vector2f(x, y);
            if (outlines)
            {
                circleShape.OutlineThickness = 10;
                circleShape.OutlineColor = Color.Magenta;
            }
            return circleShape;
        }

        public RectangleShape getRectangleShape(int x, int y, int height, int wight, bool outlines)
        {
            RectangleShape rectShape = new RectangleShape(new Vector2f(height, wight));
            rectShape.Position = new Vector2f(x, y);
            if (outlines)
            {
                rectShape.OutlineThickness = 10;
                rectShape.OutlineColor = Color.Magenta;
            }
            return rectShape;
        }
    }
}
