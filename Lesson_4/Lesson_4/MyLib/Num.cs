using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Num
    {
        static public void NewArray(int count, int min, int step)
        {
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = min + step;
                min = array[i];
                Console.WriteLine("Step - " + i + " " + array[i]);
            }
            Sum(ref array);
        }

        private static void Sum(ref int[] array)
        {
            int sumArray = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                sumArray += array[i];
            }
            Console.Write(sumArray + " ");
        }
    }
}
