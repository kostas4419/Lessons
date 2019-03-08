using System;
using System.Drawing;

namespace MyFirstGame
{
    class Star : BaseObject
    {
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        Image star = new Bitmap("img/Star.png");

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(star, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            Pos.X = Pos.X +  Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
        }
    }
}
