using CardTextGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class GameFramework
    {
        static private GameFramework _instance;

        public static GameFramework Instance()
        {
            if(_instance == null)
            {
                _instance = new GameFramework();
            }

            return _instance;

        }

        private InputManager InputManager;

        public bool isLive;

        private bool _pressQ;

        private bool _pressSpace;

        public GameFramework()
        {
            InputManager = new InputManager();
            isLive = true;
            _pressQ = false;
            _pressSpace = false;
        }

        public void FrameLoop()
        {
            InputManager.Update();

        }


        public void CheckInputKey()
        {
            // 모든프레임 키는 여기서 확인된다
            ConsoleKeyInfo inputKey = Console.ReadKey();

            if(_pressQ)
            {
                if (inputKey.Key == ConsoleKey.Y)
                {
                    isLive = false;
                }

                if(inputKey.Key == ConsoleKey.N)
                {
                   _pressQ = false;
                }
            }
            else
            {
                if (inputKey.Key == ConsoleKey.Q)
                {
                    _pressQ = true;

                    Console.WriteLine("프로그램을 종료하시겠습니까?");
                }
            }

            if(_pressSpace == false)
            {
                if (inputKey.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("가위바위 보를 하겠습니다  원하는 것을 내보세요, 1 가위, 2 바위, 3 보");
                    _pressSpace = true;
                }
            }
            else // Space 바가 눌렸을때 여기로 옴
            {
                if (inputKey.Key == ConsoleKey.D1)
                {
                    VersusGCW(0);
                    // 여기서 게임로직을 넣어서 실행하겠다 
                    Console.WriteLine("1번이 가위 눌렸습니다.");
                    _pressSpace = false;
                }
                if (inputKey.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("2번이 바위 눌렸습니다.");
                    VersusGCW(1);
                    _pressSpace = false;
                }
                if (inputKey.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("3번이 보 눌렸습니다.");
                    VersusGCW(2);
                    _pressSpace = false;
                }
            }
        }

        private void VersusGCW(int keyCode)
        {
            // 나 
            Player player = new Player();
            player.gameGCW.SetForceGCW(keyCode);

            // 컴퓨터
            Player com = new Player();
            player.gameGCW.SetRandGCW();

            BATTLERESULT isPlayerWin = GCW.GameResult(player, com);

            Console.WriteLine("승패 결과는 플레이어가 : " + isPlayerWin);
        }

    }
}
