using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Num
    {
        // создаем массив на основе переданных данных
        static public void NewArray(int count, int min, int step)
        {
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = min + step;
                min = array[i];
                // выводим на экран шаги создания массива
                Console.WriteLine("Step - " + i + " " + array[i]);
            }
            //Вызываем метод Суммы элементов массива
            Sum(ref array);

            //Вызываем метод Инверсии элементов массива
            Invers(ref array);
            // Отступ для удобства вывода
            Console.Write("\n");
            //Вызываем метод умнажения на случайное число каждого элемента массива
            Multi(ref array);
            // Отступ для удобства вывода
            Console.Write("\n");
            //Вызываем метод вычисления максимальных элементов массива
            Max(ref array);
        }

        private static void Sum(ref int[] array)
        {
            // Отступ для удобства вывода
            Console.Write("\n");
            //Приравниваем переменную к первому элементу массива
            int sumArray = array[0];
            //Перебираем массив и плюсуем к переменной
            for (int i = 1; i < array.Length - 1; i++)
            {
                sumArray += array[i];
            }
            // Выводим результат на экран
            Console.Write(sumArray + " ");

            // Отступ для удобства вывода
            Console.Write("\n\n");
        }

        static public void Invers(ref int[] array)
        {
            // Выполняем переворот массива
            int[] array2 = array.Reverse().ToArray();
            // Выводим результат на экран
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }

            // Отступ для удобства вывода
            Console.Write("\n");
        }

        static public void Multi(ref int[] array)
        {
            //Делаем копию массива
            int[] array3 = (int[])array.Clone();
            // Переменная для случайных чисел
            Random random = new Random();

            // Умножаем каждый элемент массива на случайное число
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array3[i] * random.Next(1, 9);
                // Выводим результат на экран
                Console.Write(" {0}", array3[i]);
            }
            // Отступ для удобства вывода
            Console.Write("\n");
        }

        static public void Max(ref int[] array)
        {
            int max = array.Max();
            int numberMax = 0;

            //Перебираем массив и плюсуем к переменной
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) numberMax++;

            // Выводим результат на экран
            Console.WriteLine("Количество максимальных элементов: {0} ", numberMax);
        }
    }
}
