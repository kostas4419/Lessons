using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию:");
            string lastname = Console.ReadLine();

            Console.Write("Введите ваш возраст:");
            string age = Console.ReadLine();

            Console.Write("Введите ваш рост:");
            string height = Console.ReadLine();

            Console.Write("Введите ваш вес:");
            string weight = Console.ReadLine();

            string result = name + lastname + age + height + weight;

            Console.WriteLine("Имя: " + name + " Фамилия: " + lastname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight + "");

            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, lastname, age, height, weight);

            Console.WriteLine($"Имя: {name} Фамилия: {lastname} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadKey();
        }
    }
}
