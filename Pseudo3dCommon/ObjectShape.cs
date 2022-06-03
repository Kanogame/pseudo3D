using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudo3DCommon
{
    public class ObjectShape
    {
        int x;
        int y;
        int V1;
        int V2;
        bool outlines;
        public ObjectShape(int x, int y, int V1, int V2, bool outlines)
        {
            this.x = x;
            this.y = y;
            this.V1 = V1;
            this.V2 = V2;
            this.outlines = outlines;
        }

        public CircleShape getCircleShape()
        {
            CircleShape circleShape = new CircleShape(V1, (uint)V2);
            circleShape.Position = new Vector2f(x, y);
            if (outlines)
            {
                circleShape.OutlineThickness = 10;
                circleShape.OutlineColor = Color.Magenta;
            }
            return circleShape;
        }

        public RectangleShape getRectangleShape()
        {
            RectangleShape rectShape = new RectangleShape(new Vector2f(V1, V2));
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
