using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(Shift(array, -2));
        }

        static int[] Shift(int[] array, int N)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + N;
            }
            return array;
        }
    }
}
