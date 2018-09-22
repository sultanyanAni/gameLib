using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniGameLib
{
    class Frame
    {
        public Vector2 Origin { get; set; }
        public Rectangle SourceRectangle { get; set; }

        public Frame(Vector2 origin, Rectangle rectangle)
        {
            Origin = origin;
            SourceRectangle = rectangle;
        }
    }
}
