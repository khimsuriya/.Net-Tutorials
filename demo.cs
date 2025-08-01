using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class demo
    {
        public static void Main(String[] args)
        {
            int num = 321;
            string[] units = { "zero", "one", "two", "three" };
            int temp = num;
            int[] digit = new int[10];
            int count = 0;
            while (temp > 0)
            {
                digit[count] = temp % 10;
                temp = temp / 10;
                count = count + 1;
            }
            Console.WriteLine("Number is : ");
            for(int i = count - 1; i >= 0; i++)
            {
                Console.WriteLine(units[digit[i]] + "");
            }
        }
    }
}
