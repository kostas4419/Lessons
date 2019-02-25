using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2 // Гордиенко Константин
{
    class Program
    {
        // Подсчет минимального значения
        static void Minimal(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
                min = a;
            else if (b < c)
                min = b;
            else
                min = c;

            Console.WriteLine("Минимальное значение " + min + "");
        }

        // Подсчет минимального значения, второй способ.
        static void Minimal2(int a, int b, int c)
        {
            int min = (a < b && a < c) ? a : ((b < c) ? b : c);

            Console.WriteLine("Минимальное значение " + min + "");
        }

        // Подсчетколичества цифр числа
        static void Count(int a)
        {
            int count = (int)Math.Log10(a) + 1;

            Console.WriteLine("Количество цифр числа " + a + " - " + count + "");
        }

        // Подсчет килограм
        static void Diet(double index, double weight, double height)
        {
            int newWidth = 0;
            double newIndex = index;
            if (index < 25)
            {
                for (int i = 0; newIndex < 23; i++)
                {
                    weight++;
                    newIndex = weight / (height * height);
                    newWidth = i;
                }

                Console.WriteLine("Вам нужно поправиться на " + newWidth + " кг");
            }
            else
            {
                for (int i = 0; newIndex > 23; i++)
                {
                    weight--;
                    newIndex = weight / (height * height);
                    newWidth = i;
                }

                Console.WriteLine("Вам нужно похудеть на " + newWidth + " кг");
            }
        }

        // рекурсивный вывод чисел и подсчет суммы
        static void Sort(int a, int b, int c)
        {
            if (a <= b)
            {
                Console.WriteLine("{0,4} ", a);
                c += a;
                Sort(a + 1, b, c);
            }else
            {
                Console.WriteLine("Cумма всех чисел равна " + c + "");
            }            
        }

        static void Main()
        {

            #region Упражнение 1, Возврат минимального числа

                int a = 852;
                int b = 645;
                int c = 1654;

                // Решение 1
                Minimal(a, b, c);

                //Решение 2
                Minimal2(a, b, c);
            
            #endregion

            #region Упражнение 2, Метод подсчета количества цифр числа

            int number = 1234567899;
            Count(number);

            #endregion

            #region Упражнение 3, Сумма нечетных положительных чисел.

            int total = 0;
            int pNumber = 0;
            string text;

            Console.Write("Введите положительное число или 0 для завершения.\n");

            do
            {
                text = Console.ReadLine();

                bool test = text.All(char.IsDigit);
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
                }
            } while (pNumber != 0);

            Console.WriteLine("Сумма всех введеных нечетных чисел равна " + total + "");
            #endregion

            #region Упражнение 4, Реализация проверки логина и пароля

            int attempt = 0;
            string trueLogin = "root";
            string truePass = "GeekBrains";
            bool next = false;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();

                if (login == trueLogin && pass == truePass)
                {
                    next = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Логин и Пароль не верны! Осталось попыток: " + (2 - attempt) + "\n");
                    attempt++;
                }
            } while (attempt < 3);

            if (!next)
            {
                Console.WriteLine("Доступ запрещен!");
            }
            else
            {
                Console.WriteLine("Добро пожаловать!");
            }

            #endregion

            #region Упражнение 5, Советы по весу.

            Console.Write("Введите ваш рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            double index = weight / (height * height);
            index = Math.Round(index, 1);

            if (index < 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
                Diet(index, weight, height);
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
                Diet(index, weight, height);
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Избыточная масса тела");
                Diet(index, weight, height);
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
                Diet(index, weight, height);
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
                Diet(index, weight, height);
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
                Diet(index, weight, height);

            }

            Console.WriteLine("Индекс массы вашего тела составляет : " + index + "");
            #endregion

            #region Упражнение 6, Подсчет хороших чисел
            DateTime start = DateTime.Now;
            int sum = 1;

            for (int j = 1; j <= 1000000000; j++)
            {
                int n = j;
                n = Math.Abs(n);
                sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if (j % sum == 0)
                {
                    Console.WriteLine(j);
                }
            }
            var time = DateTime.Now - start;

            Console.WriteLine("Затраченное время " + time.Minutes + "м " + time.Seconds + "с");
            #endregion

            #region Упражнение 7, Вывод чисел рекурсивным методом

            int aa = 1;
            int bb = 100;
            int cc = 0;

            Sort(aa, bb, cc);


            #endregion

            Console.ReadKey();
        }
    }
}
