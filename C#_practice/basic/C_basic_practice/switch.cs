using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_practice
{
    class if문
    {
        static void Main(string[] args)
        {
            int a = 50;

            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("짝수!");
                    break;
                case 1:
                    Console.WriteLine("홀수!");
                    break;
            }
        }
    }
}
