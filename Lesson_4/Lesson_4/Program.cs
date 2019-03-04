using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4 //Гордиенко Константин, задача 1 и 2а
{
    class Program
    {
        static void Main()
        {
            //Создаем массив из 20 элементов
            int[] array = new int[20];
            //Вызываем метод и передаем массив в качестве параметра
            StaticClass(ref array);

            Console.ReadKey();
        }

        private static void StaticClass(ref int[] array)
        {
            // Счетчик
            int count = 0;

            // Переменная для случайных чисел
            Random random = new Random();

            // Заполняем массив случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }

            // Выявляем пары в корорых только одно число делится на 3
            for (int j = 0; j < array.Length - 1; j++)
            {
                if ((array[j] % 3 == 0 && array[j + 1] % 3 != 0) || (array[j] % 3 != 0 && array[j + 1] % 3 == 0))
                {
                    count++;
                }
            }

            Console.WriteLine("Количетсво пар в корорых только одно число делится на 3 - " + count + "");

        }
    }
}
