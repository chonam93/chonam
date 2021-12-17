using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211217_study
{
    class @enum
    {
        //enum은 열거형 상수를 표현하기 위한 것으로 이를 이용하면 상수 숫자들을 보다 의미있는 단어들로 표현할 수 있어서 프로그램을 읽기 쉽게 해줌
        //enum의 각 요소는 별도의 지정없이는 첫번째 요소가 0, 두번째가 1, 세번째는 2처럼 1씩 증가된 값들을 받는다
        //enum문은 클래스 안이나 네임스페이스 안에서만 선언될 수 있다. 즉, 메서드 안에서나 속성안에서는 선언되지 않는다.



        //city라는 enum 타입 정의
        enum City
        {
            Seoul, // 0 할당
            Dadjun, // 1 할당
            Busan = 5, // 사용자가 5라고 지정해줌
            Jeju = 10 // 마찬가지
        }

        static void Main(string[] args)
        {
            City myCity;

            //enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(Casting)하는 방법. 
            // (int)를 앞에 지정.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
