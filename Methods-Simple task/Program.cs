using System;

namespace Methods_Simple_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2002, 4, 5 };
            int[] arr1 = { 1223, 785, 54, 4, 5 };
            if (massiv(arr) > massiv(arr1))
            {
                Console.WriteLine(massiv(arr));
                return;
            }               
                Console.WriteLine(massiv(arr1));
        }
        static int massiv(int[] m)
        {
            int max = m[0];

            foreach (var item in m)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }

}
