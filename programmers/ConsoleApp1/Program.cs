using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        /*        static void Main(string[] args)
                {
                    int[] numbers = new int[5] { 2, 1, 3, 4, 1 };
                    string str = "";
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            if (i != j)
                            {
                                int num = numbers[i] + numbers[j];
                                if (!str.Contains(num.ToString())) str += num.ToString() + " ";

                            }
                        }
                    }
                    string[] newstr = str.Split(' ');
                    int[] answer = Array.ConvertAll(newstr, s => int.Parse(s));

                }*/
        public class Example
        {
            public static void Main()
            {
                string[] strings = new string[] { "1", "2", "3" };

                int[] ints = Array.ConvertAll(strings, s => int.Parse(s));
                Console.WriteLine(String.Join(",", ints));
            }
        }
    }
}
