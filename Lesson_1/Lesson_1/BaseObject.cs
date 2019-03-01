﻿using System;
using System.Drawing;

namespace Lesson_1
{
    class BaseObject
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public virtual void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }

        public virtual void Update()
        {
            Pos.X = Pos.X - Dir.X;
           // Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) { Pos.X = Game.Width + Size.Width; }
            //if (Pos.X > Game.Width) { Dir.X = -Dir.X; }
            //if (Pos.Y < 0) { Dir.Y = -Dir.Y; }
            //if (Pos.Y > Game.Heigth) { Dir.Y = -Dir.Y; }
        }

    }
}