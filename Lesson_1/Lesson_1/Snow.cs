using System;
using System.Drawing;
using System.IO;
namespace Lesson_1
{
    class Snow : BaseObject
    {
        public Snow(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        public override void Draw()
        {
            Image newImage = Image.FromFile("Flower.jpg");

            Rectangle srcRect = new Rectangle(Pos.X, Pos.Y, 150, 150);
            GraphicsUnit units = GraphicsUnit.Pixel;
            float widthI = 150.0F;
            float heigthI = 150.0F;
            Game.Buffer.Graphics.DrawImage(newImage, srcRect, Dir.X, Dir.Y, widthI, heigthI, units);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) { Dir.X = Dir.X + Game.Width; }
            if (Pos.X > Game.Width) { Dir.X = -Dir.X; }
            if (Pos.Y < 0) { Dir.Y = -Dir.Y; }
            if (Pos.Y > Game.Heigth) { Dir.Y = -Dir.Y; }
        }
    }
}
