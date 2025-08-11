using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");

            Console.Write("Input the marks obtained in Maths : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathsPhysics = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
               (totalAll >= 180 || totalMathsPhysics >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

            Console.ReadLine();
        }
    }
}
