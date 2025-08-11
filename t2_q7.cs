using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q7
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; 
            x = y;    
            y = temp; 
        }
    }

    class TestRef
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");

            t2_q7 n = new t2_q7();

            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);


        }
    }
}