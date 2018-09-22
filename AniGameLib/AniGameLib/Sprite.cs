using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniGameLib
{
    class Sprite
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
        public Sprite(Texture2D image, Vector2 position)
            :this(image, position, Color.White)
        {

        }

        public Sprite(Texture2D image, Vector2 position, Color tint)
            :this(image, position, tint, Vector2.One, 0f, 0f, SpriteEffects.None, Vector2.Zero, null)
        {

        }

        public Sprite(Texture2D image, Vector2 position, Color tint, Vector2 scale)
            :this(image, position, tint, scale,0f,0f,SpriteEffects.None, Vector2.Zero, null)
        {

        }

        public Sprite(Texture2D image, Vector2 position, Color tint, Vector2 scale, float rotation, float layerDepth, SpriteEffects spriteEffect, Vector2 origin, Rectangle? sourceRectangle)
        {
            Image = image;
            Position = position;
            Tint = tint;
            Scale = scale;
            Rotation = rotation;
            LayerDepth = layerDepth;
            Origin = origin;
            SpriteEffect = spriteEffect;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(Image, Position, SourceRectangle, Tint, 0f, Origin, Scale, SpriteEffect, 0f);
        }
    }
}
