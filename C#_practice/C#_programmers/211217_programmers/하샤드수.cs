using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211217_programmers
{
    class 하샤드수
    {
        static void Main(string[] args)
        {

        }
        public bool solution(int x)
        {
            bool answer = true;
            int sum = 0;
            string num = x.ToString();
            foreach (char a in num)
            {
                sum += int.Parse(a.ToString());
            }

            if (x % sum == 0) return answer;
            else return false;



        }
    }
}
