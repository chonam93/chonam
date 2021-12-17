using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//

namespace _211217_study
{
    class foreach_while
    {
        static void Main(string[] args)
        {
            /*            string[,,] arr = new string[,,]
                        {
                            {{"1","2"}, {"11","22" } },
                            {{"3","4"}, {"33","44" } }
                        };
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for(int j = 0; j < arr.GetLength(1); j++)
                            {
                                for(int k =0; k < arr.GetLength(2); k++)
                                {
                                    Console.WriteLine(arr[i, j, k]);
                                }
                            }
                        }
                        Console.WriteLine("\n위에는 for문이고 아래는 이제 foreach문\n");

                        foreach(var s in arr)
                        {
                            Console.WriteLine(s);
                        }*/
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar);
            } while (key.Key != ConsoleKey.Q);

            Console.WriteLine("");
            foreach (char ch in keyList)
            {
                Console.Write(ch + " ");
            }    
        }
    }
}
