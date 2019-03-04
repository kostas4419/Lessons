using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Lesson_4 //Гордиенко Константин, задача 3а, 3б
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Передаем параметры в библиотеку (Колличество элементов, начальное значение, шаг)
           Num.NewArray(10, 1 , 5);

            //Задержка черного экрана
            Console.ReadKey();
        }

    }
}
