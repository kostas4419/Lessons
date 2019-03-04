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
        //static public void Invers()
        //{
        //    int[] array2 = array.Reverse().ToArray();
        //    foreach (int num in array2)
        //    {
        //        Console.Write(num + " ");
        //    }
        //}

        //static public void Multi()
        //{
        //    int[] array3 = (int[])array.Clone();
        //    // Переменная для случайных чисел
        //    Random random = new Random();

        //    // Заполняем массив случайными числами
        //    for (int i = 0; i < array3.Length; i++)
        //    {
        //        array3[i] = array3[i] * random.Next(1, 9);
        //        Console.Write(array3[i] + " ");
        //    }
        //}

        //static public void Max()
        //{
        //    double max = array.Max();
        //    double numberMax = 0;

        //    for (int i = 0; i < array.Length; i++)
        //        if (array[i] == max) numberMax++;

        //    Console.WriteLine("количество максимальных элементов: {0} ", numberMax);
        //}

        static void Main(string[] args)
        {
           Num.NewArray(10, 1 , 5);
            //sumArray();
            //array.Invers();
            //Console.WriteLine("\n");
            //array.Multi();
            //Console.WriteLine("\n");
            //array.Max();
            Console.ReadKey();
        }

    }
}
