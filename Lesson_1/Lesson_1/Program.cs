using System;
using System.Windows.Forms;

namespace MyFirstGame // Гордиенко Константин
{
    class Program 
    {

        static void Main(string[] args)
        {


            Form form = new Form
            {

                Width = 800,
                Height = 600
            };


            Game.Init(form);
            form.Show();
            Game.Load();
            Game.Draw();
            Application.Run(form);
        }
    }
} 
