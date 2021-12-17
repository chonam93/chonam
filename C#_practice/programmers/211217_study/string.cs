using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211217_study
{
    class @string
    {
        static void Main(string[] args)
        {
            string s = "C# Studies";

            // 문자열을 배열인덱스로 한문자 엑세스 
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }

            // 문자열을 문자배열로 변환
            string str = "Hello";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            // 문자배열을 문자열로 변환
            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

            Console.WriteLine(s);

            // 문자 연산
            char c1 = 'A';
            char c2 = (char)(c1 + 3);
            Console.WriteLine(c2);  // D 출력



            //string 클래스는 Immutable이기 때문에 문자열 갱신을 요하는 프로그램에는 적당하지 않음
            //그럴때는 mutable인 StringBuilder 클래스를 사용 >>> 별도 메모리를 생성,소멸하지 않고 일정한 버퍼를 가지고 문자열 갱신을 효율적으로 처리해줌
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                //sb.Append(System.Environment.NewLine);
            }
            Console.WriteLine(sb);

            string j = sb.ToString();

            Console.WriteLine(j);

        }
    }
}
