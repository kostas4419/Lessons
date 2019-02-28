using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2 // Константин Гордиенко
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Упражнение 3, Сумма нечетных положительных чисел.

            int total = 0;
            int pNumber = 1;
            string text;

            Console.Write("Введите положительное число или 0 для завершения.\n");

            do
            {
                text = Console.ReadLine();

                bool test = Int32.TryParse(text, out pNumber);
                if (test)
                {
                    pNumber = Convert.ToInt32(text);
                    if (pNumber != 0)
                    {
                        if (pNumber % 2 == 1)
                        {
                            total += pNumber;
                        }
                        Console.WriteLine("Введите следующее число");
                    }

                }
                else
                {
                    Console.WriteLine("Разрешен ввод только положительных чисел!");
                    pNumber = 1;
                }
            } while (pNumber != 0);

            Console.WriteLine("Сумма всех введеных нечетных чисел равна " + total + "");
            #endregion

            Console.ReadKey();
        }
    }
}
