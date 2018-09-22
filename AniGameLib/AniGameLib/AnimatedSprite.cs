using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniGameLib
{
    class AnimatedSprite
    {
        public Texture2D Image { get; set; }
        public Vector2 Position { get; set; }
        public Color Tint { get; set; }
        public Vector2 Scale { get; set; }
        public float Rotation { get; set; }
        public float LayerDepth { get; set; }
        public SpriteEffects SpriteEffect { get; set; }
        public Vector2 Origin { get; set; }
        public Rectangle? SourceRectangle { get; set; }
        public Rectangle HitBox
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)(Image.Width * Scale.X), (int)(Image.Height * Scale.Y));
            }

        }

        public List<Frame> Frames { get; set; }

        int currentIndex = 0;

        TimeSpan elapsedTime = TimeSpan.Zero;
        TimeSpan updateTime; 

        public AnimatedSprite()
        {

        }

        
    }
}
