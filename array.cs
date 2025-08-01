using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class array
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = a[0];
            int min = a[0];

            //foreach (int i in a)
            //{
            //    if (i > max)
            //    {
            //        max = i;
            //    }
            //    if (i < min)
            //    {
            //        min = i;
            //    }
            //}
            Console.WriteLine("max num is " + a.Max());
            Console.WriteLine("min num is " + a.Min());
            Console.WriteLine("Sum of element " + a.Sum());
            Console.WriteLine("Average is " + a.Average());
            Console.WriteLine("Total element ");
            Array.Sort(a);
            Console.WriteLine("sorted array is " + string.Join("", a));
            Array.Reverse(a);
            Console.WriteLine("reverse array is " + string.Join("", a));
        }
    }
}
