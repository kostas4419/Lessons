using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson_1 // Гордиенко Константин
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;

        public static int Width { get; set; }
        public static int Heigth { get; set; }

        static Game()
        {
        }

        public static void Init(Form form)
        {
            Graphics g;

            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();

            Width = form.ClientSize.Width;
            Heigth = form.ClientSize.Height;

            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Heigth));

            Load();

            Timer timer = new Timer();
            timer.Interval = 2;
            timer.Start();
            timer.Tick += Timer_Tick;


        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            
            Draw();
            Update();
        }

        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);

            foreach  (BaseObject obj in _objs)
            {
                obj.Draw();
                Buffer.Render();
            }
        }

        public static void Update()
        {
            foreach (BaseObject obj in _objs)
            {
                obj.Update();
            }
        }

        public static BaseObject[] _objs;
        public static void Load()
        {
            _objs = new BaseObject[30];
            for (int i = 0; i < _objs.Length / 2; i++)
            {
                _objs[i] = new BaseObject(new Point(600, i * 20), new Point(-i, -i), new Size(10, 10));
            }

            //Пример рисованых звезд
            //for (int i = _objs.Length / 2; i < _objs.Length; i++)
            //{
            //    _objs[i] = new Star(new Point(600, i * 20), new Point(-i, 0), new Size(5, 5));
            //}

            // Пример картинок
            for (int i = _objs.Length / 2; i < _objs.Length; i++)
            {
                _objs[i] = new Snow(new Point(600, i * 20), new Point(-i, -i), new Size(150, 150));
            }
        }


    }
}
