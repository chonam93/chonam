using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_practice
{
    class do_while
    {
        static void Main(string[] args)
        {
            int num = 1;

            /*while (num <= 10)
                Console.WriteLine(" num is {0}", num++);
                */

            do
            {
                Console.WriteLine("num is {0}", num++);
            } while (num <= 10);
        }
    }
}
