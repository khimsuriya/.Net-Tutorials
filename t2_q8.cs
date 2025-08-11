using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q8
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());

            int sum = x + y + z;

            return sum;
        }
    }

    class TestOut
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");
            t2_q8 n = new t2_q8();

            int a, b, c, sum;

            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0} ", sum);
        }

    }
}