using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_행렬의덧셈
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] solution(int[,] arr1, int[,] arr2)
            {
                int[,] answer = new int[arr1.Length(0), arr1.Length(1)];
                for (int i = 0; i<arr1.Length(1); i++)
                {
                    for(int j = 0; j < arr1.Length(1); j++)
                    {
                        answer[i,j] = arr1[i,j] + arr2[i,j]
                    }
                }
                return answer;
            }

            int[,] arr1 = { { 1, 2 }, { 2, 3 } };
            int[,] arr2 = { { 3, 4 }, { 5, 6 } };
            solution(arr1, arr2);

        
        }
    }
}
