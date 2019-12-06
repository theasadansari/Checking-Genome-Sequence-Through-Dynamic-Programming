using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Genome
    {
        public int CHECKER(char[] Point1, char[] Point2, int m, int n)
        {
            //2d Array
            int[,] L = new int[m + 1, n + 1];
            //comparison of two DNA
            for (int i = 0; i < m + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == 0 || j == 0)
                        L[i,j] = 0;

                    else if (Point1[i - 1] == Point2[j - 1])
                        L[i,j] = L[i - 1,j - 1] + 1;

                    else
                        L[i,j] = Math.Max(L[i - 1,j], L[i,j - 1]);
                }
            }
            //Return Maximum length of matching DNA string.
            return L[m, n];
        }

    }
}
