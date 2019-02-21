using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center
{
    class Program
    {
        static void Data(string name, string lastname, string city)
            {
               string text = $"Имя: {name} Фамилия: {lastname} Город: {city}";
               int length = text.Length / 2;

               Console.SetCursorPosition(Console.WindowWidth / 2 - length, Console.WindowHeight / 2);
               Console.WriteLine(text); 
            }

        static void Main()
        {
            /* Решение первое */
            //string name = "Константин";
            //string lastname = "Гордиенко";
            //string city = "Москва";

            //string text = $"Имя: {name} Фамилия: {lastname} Город: {city}";
            //int length = text.Length/2;

            //Console.SetCursorPosition(Console.WindowWidth / 2 - length, Console.WindowHeight / 2);
            //Console.WriteLine(text);

            /* решение второе */
            Data("Константин","Гордиенко","Москва");

            Console.ReadKey();
        }
    }
}
