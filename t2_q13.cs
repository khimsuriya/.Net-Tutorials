using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");

            Console.Write("Input: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCount = new int[notes.Length];

            int remaining = amount;
            for (int i = 0; i < notes.Length; i++)
            {
                if (remaining >= notes[i])
                {
                    noteCount[i] = remaining / notes[i];
                    remaining %= notes[i];
                }
            }

            Console.WriteLine("\nOutput:");
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Notes of Rs.{0} = {1}", notes[i], noteCount[i]);
            }

            Console.ReadLine();
        }
    }
}
