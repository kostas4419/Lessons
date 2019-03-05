using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyFirstGame // Гордиенко Константин
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

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="form">Форма</param>
        public static void Init(Form form)
        {
            Graphics g;

            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            
            try
            {
                Width = form.ClientSize.Width;
                Heigth = form.ClientSize.Height;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: {0}", outOfRange.Message);
            }

            if (Width > 1000 || Heigth > 1000)
            {
                throw new ArgumentOutOfRangeException("Вызов формы", "Ширина или высота не должна превышать 1000 px");
            }

            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Heigth));

            Load();

            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Start();
            timer.Tick += Timer_Tick;


        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        /// <summary>
        /// Отрисовка объектов
        /// </summary>
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.FromArgb(255, 0, 5, 15));

            foreach  (BaseObject obj in _objs)
                obj.Draw();
            foreach (Asteroid obj in _asteroid)
            {
                obj.Draw();
                _bullet.Draw();
                Buffer.Render();
            }
        }

        /// <summary>
        /// Обновление объектов
        /// </summary>
        public static void Update()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
            foreach (Asteroid a in _asteroid)
            {
                a.Update();
                if (a.Collision(_bullet))
                {
                    System.Media.SystemSounds.Hand.Play();
                    var random = new Random();
                    int r = random.Next(100, Heigth - 100);
                    _bullet = new Bullet(new Point(0, r), new Point(5, 0), new Size(4, 1));
                }
            }
            _bullet.Update();
        }


        
        private static BaseObject[] _objs;
        private static Bullet _bullet;
        private static Asteroid[] _asteroid;
        /// <summary>
        /// Загрузка объектов
        /// </summary>
        public static void Load()
        {
            _objs = new BaseObject[30];
            _bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
            _asteroid = new Asteroid[20];

            var random = new Random();
            for (int i = 0; i < _objs.Length; i++)
            {
                int r = random.Next(5, 50);
                _objs[i] = new Star(new Point(1000, random.Next(0, Game.Heigth)), new Point(-r, r), new Size(3, 3));
            }

            
            for (int i = 0; i < _asteroid.Length; i++)
            {
                int r = random.Next(5, 50);
                _asteroid[i] = new Asteroid(new Point(1000, random.Next(0, Game.Heigth)), new Point(-r / 5, r), new Size(r, r));
            }

        }


    }
}
