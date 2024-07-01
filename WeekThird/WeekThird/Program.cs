using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace WeekThird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 컴퓨터는 위에서 아래로 읽는다
            // 2. 컴퓨터는 알려 준 것만 알고 있다. ( 위에서 알려줘야 밑에서 알고 있다 )
            // 3. 어떤 것을 사용할 지 알려준다.
            // 4. 3에서 사용할 이름을 지어준다. ( 변수 )
            // 5. 4에 대입한다


            Console.WriteLine("Hello, World!");

            int number_a, number_b, number_c;  // 선언 

            number_a = 10; // 대입
            number_b = 20; // 대입 
            number_c = 30; // 대입

            // 조건문  
            if (true)   // 만약 참이라면 { } 안으로 들어가서 위에서 아래로 읽는다
            {
                Console.WriteLine("조건문 참입니다.");
            }
            else  // 거짓이렴 else 안으로 들어가서 읽는다. 
            {
                Console.WriteLine("조건문 거짓압니다.");
            }


            // 비교 연산자   , 오른쪽에 있는 항목이 맞거나 틀린것을 왼쪽으로 보내줄 수 있다. 
            bool result =  number_a == number_b;  // > , < , >=, <= , !=  크다, 작다, 크거나 같다, 작거나 크다, 같지 않다

            // 비교 연산자 추가 
            // And -> && 왼쪽 항과 오른쪽항이 같은경우 true를 반환
            // Or -> || 양쪽 항중 어떤 1개라도 참인경우 참을 반환

            bool temp_a = false;
            bool temp_b = true;

            result =  temp_a && temp_b;
            result = temp_a || temp_b;

            // 문제 
            // a는 b보다 작고 b가 c보다 큰 경우를 작성하시오
            // a는 b보다 작거나 b가 c보다 큰 경우를 작성하시오 

            if(number_a < number_b && number_b > number_c)
            {
                Console.WriteLine(" a는 b보다 작고 b가 c보다 큰 경우");
            }

            if (number_a < number_b || number_b > number_c)
            {
                Console.WriteLine(" a는 b보다 작거나 b가 c보다 큰 경우 ");
                //  프로그램을 변경하는경우로 추가 -> 둘중에 어떤 경우야 ?
                if(number_a < number_b)
                {
                    Console.WriteLine(" a는 b보다 작어");
                }
                else
                {
                    Console.WriteLine(" b가 c보다 큰 경우");
                }
            }
            else
            {
                Console.WriteLine("둘다 아님");
            }

            // 위 항목을 진행한 다음에 elseif를 한번 하고 지나가자 

            if (number_a < number_b)
            {
                Console.WriteLine(" a는 b보다 작어");
            }
            else if(number_b > number_c)
            {
                Console.WriteLine(" b가 c보다 큰 경우");
            }
            else
            {
                Console.WriteLine("둘다 아님");
            }


            // 복습 기대 사항 : 반복문을 사용할 수 있다,  조건문을 사용해 원하는 시점에서 반복문을 빠져 나갈 수 있다.
            //  위에서 사용한 변수의 재활용이 된다 , 반복문을 빠져 나온 이후 변수의 값을 확인해보자. 
            // Debug깅 스킬을 추가해서 알려줘보자 --- 

            // 반복문을 써보자 
            result = true;

            while(result)
            {
                number_a++;

                if(number_a > number_b)
                {
                    result = false;
                    Console.WriteLine("반복문 빠져 나감");
                }

            }

            // 여기서 number_a는 몇일까요? 출력해 봅시다 
            // 기대사항  : 변수가어떻게 변화되는지보게 된다. 

            // number_a를 다시 원점으로 돌려 놓아보자 

            int count = 10;

            for(int index = 0; index < count; index++)
            {
                number_a++;
            }

            // 자 그런데 여기서 실수로 내가 count를 잘못넣었어 그래서 중간에 바꾸고싶단말야 
            for (int index = 0; index < count; index++)
            {
                if (number_a >= count)
                    break;  // continue 를 써준다

                number_a++;
            }

            // class 를 알려줘 봅니다. struct는 클래스를 다 배우고 나서 알려줍니다.             

            // 아래에 클래스를 선언하고 !

            HumanBody myBody = null;   // 여기서 null 을 알려줘본다.  , 생성자는 나중에 알려줄것 

            // 빈 클래스를 일단 만들어서 사용해보자 
            Console.WriteLine("mybody class : " + myBody); //

            myBody = new HumanBody(); // 힙에 할당한다.   ---> 지금까지 선언한 데이터타입과 다른점을 설명한다. 

            // string 은 별개였다는것을 강조하고  유일하게 string는 클래스라고알려준다. 

            // 키와 나이를 넣고 출력해본다 
            // 즉 클래스는 내가 관리하고 싶은 데이터를 넣을 수 있는 나만의 가방이라고 생각하면 된다.
            Console.WriteLine( "내 나이는 : " + myBody.height);

            // 생각해보니까 아직 내 키랑 나이를 알려준적이 없음  컴퓨터한테 알려주자.
            // 여기서 Class.으로 접근하는 방법을 알려준다. 
            myBody.height = 174.5f;


            // 그리고 나서  나이를 출력하라고 해본다 : 내 나이는 ..... 
            Console.WriteLine("내 나이는 : " + myBody.age);

            // 여기까지하면 클래스에 변수를 선언하고, 대입하는것을 할 수 있다는것을 기대할 수 있다. 

            // 이름도 출력해봅시다. 

            // 이제 함수를 들어가 본다. -----> 함수의 모양을 알려준다 
            // void 함수명 () ================> 함수의 원형이다. 
            // 우리가 지금 출력하고있는 WriteLine을 이미 함수로 사용하고 있다는것을 다시 설명해준다. 

            // 실제 ShowAge함수를 만들어서 보여준다. 
            myBody.ShowAge();

            // 우리 강좌를 받는 학생을 관리하는 프로그램을 만든다고 하자.
            //  나이와 키와 이름....기타 등등의 정보들을 가지고 있을수있으니 클래스로 관리하기로 하였다.

            HumanBody bestFriend = new HumanBody();
            // 하나를 추가해서  똑같이 출력해보자 

            // 함수를 다 이해했다면 다음단계 파라미터를 넘겨줄 수 있는 함수를 알려준다.
            //  파라미터는 스택에 선언되는 변수이며  { } 에서 빠져나가는 순간 사라지는 변수를 알려준다. 
            // 스택과 힙의 차이를 알려주면서 지역변수를 알려주면된다. 


            // 파라미터로 받는 함수를 만들어보라고 한다. 키를 출력하는 함수를 만들어보세요. 


            // 위에 항목이 다 끝났다면 이제 생성자를 파라미터로 받아서 만들 수 있다는 것을 알려준다. 

            // 이제 생성자 까지 설명이 끝났다면 
            // 생각해보니 나이는 너무 개인정보라 감춰야할꺼 같다고한다. 
            // public와 private 의 차이점을 설명해준다 .

            // private 로 선언한것은 .으로 호출할 수 없음을 보여준다 .

            // 일단 여러분은 모두 public 으로 선언하고 사용하되 어느 순간에 private를 사용해야할지 아는 순간에 쓰면 된다. 
            // 물론 취업을 희망하는분은 그전에 깨달아야 하는 내용이고, 나혼자 프로그램을 짜는 사람하고는 무관하다. 


            // 이제 함수는 파라미터의 개수가 다르면 같은 이름을 써도 컴퓨터는 다른것으로 인식하는것을 추가로 알려준다. 
            // 함수의 이름을 같게 변경해보자 ShowInputAge -> ShowAge


            // 생성자로 가상의 친구의 이름을 만들고 데이터를 넣고출력해보자 

            //  이제 4명의 친구를 만든다 생각하고 배열에다가 하나씩 넣어보자. 
            // 이 예제는 전부 직접 쓰면서 설명한다. 

            // 이제 실습시간 : House 클래스를 만들고 집 가격을 적어서 넣어보자 ,
            // 집 이름: 한남 10, 서초 , 종로, 강남  
            // 4개의 집가격이 들어가있는 클래스를 만들고  
            //  집 가격이 얼마인지 출력하는 함수를 만들고 
            // 집 데이터를  배열로 관리해서  
            // 반복문을 사용해서 집 가격을 출력해보자
            // 


            // 이제 struct를 들어가야하지만 어떤 모양인지만 설명하고 
            // stack 에서 빠지면 어떻게 값타입은 변화하는지 알아보자.  {} 를 나가는 순간 알수없는 값이 됨을 보여준다. 

            ValueCase temp_1 = new ValueCase();
            ValueCase temp_2 = new ValueCase();
            temp_1.Number = 10;
            temp_1.Index = 1;

            Console.WriteLine(" temp_1 의 인덱스 : " + temp_1.Index + ", temp_1의 넘버 :" + temp_1.Number);

            temp_2.Number = 20;
            temp_2.Index = 2;

            temp_1 = temp_2;

            Console.WriteLine(" temp_1 의 인덱스 : " + temp_1.Index + ", temp_1의 넘버 :" + temp_1.Number);

            temp_1.Number = 10;

            Console.WriteLine(" temp_1 의 인덱스 : " + temp_1.Index + ", temp_1의 넘버 :" + temp_1.Number);
            Console.WriteLine(" temp_2 의 인덱스 : " + temp_2.Index + ", temp_2의 넘버 :" + temp_2.Number);

            // struct의 학습이 끝났다면  이제 상속으로 넘어가면 된다 .

        }

        // 몸을 설계 해 봅시다. 
        public class HumanBody
        {
            public string Name;
            public float height;
            public int age;


            // 함수의 이름은 동사로 시작하는게 대다수, 반드시 함수의 목적에 맞게 이름을 짓도록 명심 
            public void ShowAge()
            {
                Console.WriteLine("내 나이는 : " + age);
            }

            public void ShowInputAge(int intputAge)
            {
                Console.WriteLine("내 나이는 : " + intputAge);
            }

        }

        public class House
        {
            public string Name;
            public int Price;
        }

        public struct ValueCase
        {
            public int Number;
            public int Index;
        }


    }
}