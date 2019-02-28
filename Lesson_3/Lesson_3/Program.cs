using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3 // Гордиенко Константин
{

    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 0;

            Complex x1;
            x1.a = 10;
            x1.b = 5;

            Complex x2;
            x2.a = 20;
            x2.b = 15;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine($"x1 = {x1.a} + {x1.b}i");
                    break;
                case 2:
                    Console.WriteLine($"x2 = {x2.a} + {x2.b}i");
                    break;
                case 3:
                    Complex x3 = Complex.Sub(x1, x2);
                    Console.WriteLine($"x3 = {x3.a} + {x3.b}i");
                    break;
                default:
                    Complex x4 = Complex.Mult(x1, x2);
                    Console.WriteLine($"x4 = {x4.a} + {x4.b}i");
                    break;
            }

            Console.ReadKey();
        }
    }
}
