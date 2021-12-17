using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211217_programmers
{
    class 나누어떨어지는숫자배열
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            int sum = 0;
            foreach (int num in arr)
            {
                if (num % divisor == 0)
                {
                    answer[sum] = num;
                    sum += 1;
                }
            }
        }
    }
}
