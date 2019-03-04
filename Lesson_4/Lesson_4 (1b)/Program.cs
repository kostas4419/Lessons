using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4 //Гордиенко Константин, задача 2б и 2в
{
    class Program
    {
        static void Main()
        {
            // Проверяем существует ли файл
            if (File.Exists("Text.txt"))
            {
                //Считываем данные из файла
                string[] file = File.ReadAllLines(@"Text.txt");

                //Преобразуем string массив в int массив
                int[] array = file.Select(s => int.Parse(s)).ToArray();

                //Вызываем метод и передаем массив в качестве параметра
                StaticClass(ref array);
            }
            else {
                Console.WriteLine("Файл по указанному адресу отсутствует!!!");
            }
            Console.ReadKey();
        }

        private static void StaticClass(ref int[] array)
        {
            // Счетчик
            int count = 0;
            
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
