using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class t2_q10
    {
        public static int MatSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1;

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                    return 1;
                else if (mat[i, j] > X)
                    j--; 
                else
                    i++; 
            }
            return 0;
        }

        public static void Main()
        {
            Console.WriteLine("24SOECE13032 - KHIMSURIYA KINJAL");
            int[,] mat2 = {
                { 18, 21, 27, 38, 55, 67 }
            };
            int N2 = 1, M2 = 6, X2 = 55;
            Console.WriteLine("Output : " + MatSearch(mat2, N2, M2, X2)); 
        }
    }
}
