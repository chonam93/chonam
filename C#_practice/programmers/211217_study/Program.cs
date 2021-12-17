using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//변수는 메서드 안에서 해당 메서드의 로컬변수로 선언되거나,
//클래스 안에서 클래스 내의 멤버들이 사용하는 전역적변수(이를 필드라고부름)로 선언될 수 있다
//로컬 변수는 해당 메서드 내에서만 사용되며, 메서드 호출이 끝나면 소멸됨.
//반면 필드(전역적변수)는 클래스의 객체가 살아있는 한 계속 존속함

//C#의 모든 변수는 대소문자를 구분함. var1 과 Var1은 다름


namespace _211217_study
{
    class Program
    {
        //필드 (클래스 내에서 공통적으로 사용되는 전역변수
        //필드의 경우 값을 설정안해주면 기본값으로 설정됨. int의 경우 0로 할당된다~

        int globalVar;
        const int MAX = 1024; //const (constant) 안변함. 상수 정의할 때 사용함


        public void Method1()
        {
            //로컬변수
            int localVar;
            localVar = 100; //로컬변수는 값을 할당해줘야한다. 안해주면 에러발생;


            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);

        }
    }
    class Program2
    {
        //모든 프로그램에는 MAIN이 있어야한다
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Method1();
        }
    }

    
}
