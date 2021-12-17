using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//배열은 파이썬 리스트같은 느낌.
//C#에서는 최고 32차 배열까지 가질 수 있음
//
namespace _211217_study
{
    class Array
    {
        static void Main(string[] args)
        {
            //string 형태의 배열을 만들건데 배열의 크기는 10이다! 배열의 값은 아직 정해지지 않음
            string[] players = new string[10];
            
            //만들 때 아예 값을 지정해줄 수 있음. 이놈은 크기 3의 배열
            string[] Regions = { "서울", "경기", "부산" };

            //2차원 배열은 이렇게 만든다. []안에 , 넣어줌. 
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            //3차원 배열 선언
            string[,,] Cubes;




            //가변배열 (Jagged Arrray)
            //배열의 배열(array of array)라고도 부르는데 첫번째 차원의 크기는 컴파일 타임에 확정되어야 하고 그 이상 차원은 런타임시 동적으로 서로 다른 크기의 배열로
            ////지정할 수 있다
            
            //1차 배열크기는 명시해야한다. 여기서는 3
            int[][] A = new int[3][];

            A[0] = new int[2];
            A[1] = new int[3];
            A[2] = new int[4];



            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine(sum);
        }
    }
}
