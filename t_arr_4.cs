using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t_arr_4
    {
        static void Main()
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] copiedArray = new int[originalArray.Length];
            Array.Copy(originalArray, copiedArray, originalArray.Length);
            Console.WriteLine("Original Array:");
            foreach (int element in originalArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nCopied Array:");
            foreach (int element in copiedArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
