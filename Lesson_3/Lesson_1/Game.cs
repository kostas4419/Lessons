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

        private static Timer _timer = new Timer();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="form">Форма</param>
        public static void Init(Form form)
        {
            Graphics g;

            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            
            Width = form.ClientSize.Width;
            Heigth = form.ClientSize.Height;       

            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Heigth));

            Load();

            _timer.Interval = 20;
            _timer.Start();
            _timer.Tick += Timer_Tick;

            form.KeyDown += Form_KeyDown;

            Ship.MessageDie += Finish;
        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) _bullet = new Bullet(new Point(_ship.Rect.X + 10, _ship.Rect.Y + 4), new Point(4, 0), new Size(4, 1));
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Finish()
        {
            _timer.Stop();
            Buffer.Graphics.DrawString("The End", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Render();
        }

        /// <summary>
        /// Отрисовка объектов
        /// </summary>
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.FromArgb(255, 0, 34, 85));

            foreach  (BaseObject obj in _objs)
                obj.Draw();
            foreach (Asteroid obj in _asteroid)
            {
                obj?.Draw();
            }
            _bullet?.Draw();
            _ship?.Draw();
            if (_ship != null)
                Buffer.Graphics.DrawString("Energy:" + _ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);
            Buffer.Render();
        }

        /// <summary>
        /// Обновление объектов
        /// </summary>
        public static void Update()
        {
            foreach (BaseObject obj in _objs)
            {
                obj.Update();
                _bullet?.Update();
            }
            for (int i = 0; i < _asteroid.Length; i++)
            {
                if (_asteroid[i] == null) continue;
                _asteroid[i].Update();
                if (_bullet != null && _bullet.Collision(_asteroid[i]))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _asteroid[i] = null;
                    _bullet = null;
                    continue;
                }
                if (!_ship.Collision(_asteroid[i])) continue;
                var random = new Random();
                _ship?.EnergyLow(random.Next(1,10));
                System.Media.SystemSounds.Asterisk.Play();
                if (_ship.Energy <= 0) _ship?.Die();
            }
                
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
        private static Ship _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(71, 38));
        /// <summary>
        /// Загрузка объектов
        /// </summary>
        public static void Load()
        {
            _objs = new BaseObject[30];
            _bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
            _asteroid = new Asteroid[4];

            var random = new Random();
            for (int i = 0; i < _objs.Length; i++)
            {
                int r = random.Next(5, 50);
                _objs[i] = new Star(new Point(1000, random.Next(0, Game.Heigth)), new Point(-r, r), new Size(11, 10));
            }

            
            for (int i = 0; i < _asteroid.Length; i++)
            {
                int r = random.Next(5, 50);
                _asteroid[i] = new Asteroid(new Point(1000, random.Next(0, Game.Heigth)), new Point(-r / 5, r), new Size(53, 33));
            }

        }


    }
}
