using System.ComponentModel;
using TextGame;

namespace CardTextGame
{
    // 오늘의 수업내용 

    // GameFramework는 이제 본인의 역할을 찾아간다.
    // 프로그램 상태를 관리하고
    // 전체적인 것을 관장한다. 관련된것들을 총 관리하는 느낌으로 

    // Input을 분리해보도록하자

    // 1 Input매니저를 만들어보면서 Delegate에 대한 것을 활용해보자
    // 2. Game 결과를 만들어서 컨테이너에서 지난기록 결과를 잘 보여줄 수 있는지 확인해보자 


    // 이것을다 하고 나면 이제 카드게임 만들기로 들어간다 .
    // 카드 컨테이너 -> 카드를 10장을 -1~8 까지 섞어서 가지고 있는 컨테이너에
    // 랜덤으로 2장을 주고 그 두장을 곱한값을 가지고 겨루는 게임을 만들어 보도록 하자 .
    // 그리고 그 관련 결과를 원할때 출력할 수 있도록 저장하도록 하자 .



    

    
    internal class Program
    {
        public enum SantaInput : ushort
        {
            NONE = 0,
            I = 1 << 1, // 2
            O = 1 << 2, // 4
            K = 1 << 3, // 8
            L = 1 << 4, // 16

            ALPHA1 = 5,
            ALPHA2 = 6,
            ALPHA3 = 9,
            ALPHA4 = 7,
            ALPHA5 = 9,
            ALPHA6 = 10,
            ALPHA7 = 11, // 13 
            ALPHA8 = 12, // 14
            ALPHA9 = 18,
            ALPHA0,
            MINUS,
            PLUS,
            SPWAN,
            SUMMON,
            LEFT,
            RIGHT,
            UP,
            DOWN,
            LEFT_UP,
            RIGHT_UP,
            LEFT_DOWN,
            RIGHT_DOWN,
            A,
            S,
            D,
            F,
            Q,
            W,
            E,
            R,
            C,
            Z,
            X,
            V,
            ESCAPE,
            SELECTAGENT,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            LEFT_PRESS,
            RIGHT_PRESS,
            UP_PRESS,
            DOWN_PRESS,
            CMD = 100, // 이 아래다 등록하면 예외처리됨 
            CMD_READY, // 호스트만 보내는 명령어
            CMD_START, // 호스트만 보내는 명령어
            CMD_BASE_CREATURE,
            CMD_END,

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Game Start");

            GameFramework gameFramework = new GameFramework();


            while (gameFramework.isLive)
            {
                gameFramework.CheckInputKey();

                ConsoleKeyInfo inputKey = Console.ReadKey();

                if (inputKey.Key == ConsoleKey.A)
                {
                    Console.WriteLine((int)SantaInput.I);
                    Console.WriteLine((int)SantaInput.O);
                    Console.WriteLine((int)SantaInput.K);
                    Console.WriteLine((int)SantaInput.L);
                    Console.WriteLine("============================");

                    Console.WriteLine((int)SantaInput.ALPHA1);
                    Console.WriteLine((int)SantaInput.ALPHA2);
                    Console.WriteLine((int)SantaInput.ALPHA5);
                    Console.WriteLine((int)SantaInput.ALPHA9);

                }
            }

            Console.WriteLine("프로그램 종료됨");
        }
    }
}