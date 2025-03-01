﻿using System; //  .Net에 어떤 기능을 사용할 것인가 

namespace BasicClass  // 내가 만든 구역이다. 
{
    class Program   // 시작 프로그램 클래스 
    {
        // 최초의 함수 
        static void Main(string[] args)  //  프로그램이 시작되면서 들어오는 진입 점 
        {
            Console.WriteLine("Hello World!"); // .Net의 System namespace구역 안에 있는 Console창을 띄우고, 거기에 괄호 안에 내용을 출력하라는 함수 호출


            // 컴퓨터는 위에서 부터 읽으면서 내려오면서 명령문을 실행함 .

            // 컴퓨터가 이해하는 영역은 명령줄, 다음 { } 단위로 구분한다.  { } 스코프 영역을 들어갔다 나오면 없어지는것 추가 알려줌.
            // Stack 메모리에 대한 설명을 추가로 전해준 후  지역 변수에 대한 값이 없어지는것을 공유하자


            // 데이터 타입 정의 및 변수에 대입 개념 알기 
            bool winLose = false;  // bool 타입을 선언하고 변수의 이름을 짓고 값을 대입함.
            int number;
            float fNumber;
            string text = "testestse";

            // 규칙 
            // 1. 선언 -> 변수 명 -> 값 대입  한 세트로 생각해야한다.  대입은 나중에 대입해도 된다.
            // 2. 변수에 대입하는 의미는 새로운 값으로 덮어 쓴다. 즉 이전값이 있어도 새로운 값으로 갱신된다.
            // 3. 변수는 같은 값만 대입이 가능하다. - 특 언어마다 다르다.

            // 연산 + , -  * , / , % 
            int resultNumber = 10 + 10; // ->  상수를 사용해서 대입되는것을 확인하고 , 변수를 사용해서 대체하는것을 실습한다.
                                        //  int, float 를 섞어서 연산하면서  형변환 시키는 부분 적용하는것을 설명한다.

            // 연산 후 논리 값으로 나오는 부분설명 
            // > < ==  그거나 작다, 작거나 같다, 등의 논리 값으로 나오는 연산자 설명
            // bool 값으로 결과가 나오는것을  log그로 확인한다. 

            // 여기서 이제 string 문자열의 비교를 진행하며 이제 인풋을 받아보기로 한다
            // 인풋의 스트링을 받아가면서 비교를 진행 

            if (args != null && args.Length > 1)
            {
                Console.WriteLine(args[1]);

                if (args[1] == "+")
                {
                    Console.WriteLine("더하기를 진행하겠습니다.");
                }
            }

            // 논리 연산문 
            /*if(bool)  // 이것이 맞느냐 틀리느냐를 알려주는 구문이다. 맞으면 스코프 영역으로 들어간다
            {

            }
            else  // 틀리면 
            {

            }*/

            // 논리 연산으로 들어가는 문제를 출력한다. 계산기 만들기를 시작한다
            // and, or 연산 추가 알려줌 들어가야함 



            // 사칙 연산 관련된 것을 함수로 만들기 

            // 이제 반복문을 들어가면 되겠다. 
            // while 반복문
            // for 반복문 
            // foreach 는 나중에 



            // 클래스 만들기 ,  -> 후에 struct 만들기들어감 




        }
    }
}
