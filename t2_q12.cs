using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");

            int[] arr = { 10, 20, 30, 40, 50 };

            Console.Write("Enter element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

        }
    }
}
