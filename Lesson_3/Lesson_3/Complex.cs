using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    struct Complex
    {
        public double a, b;

        public static Complex Sub(Complex x1, Complex x2)
        {
            Complex res;
            res.a = x1.a - x2.a;
            res.b = x1.b - x2.b;
            return res;
        }

        public static Complex Mult(Complex x1, Complex x2)
        {
            Complex res;
            res.a = x1.a * x2.a;
            res.b = x1.b * x2.b;
            return res;
        }
    }
}
