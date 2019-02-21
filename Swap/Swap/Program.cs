using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первую переменную: ");
            var a = Console.ReadLine();

            Console.Write("Введите вторую переменную: ");
            var b = Console.ReadLine();

            //var c = a;
            //a = b;
            //b = c;

            b = b + a;
            a = b.Substring(0,b.Length - a.Length);
            b = b.Substring(a.Length);

            Console.WriteLine("Первая переменная " + a + "\nВторая переменная "+ b + "");

            Console.ReadKey();
        }
    }
}
