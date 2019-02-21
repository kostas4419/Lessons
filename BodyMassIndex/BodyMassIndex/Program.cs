using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваш рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            double index = weight / (height * height);
            index = Math.Round(index, 2);

            Console.WriteLine("Индекс массы вашего тела составляет : " + index + "");

            Console.ReadKey();
        }
    }
}
