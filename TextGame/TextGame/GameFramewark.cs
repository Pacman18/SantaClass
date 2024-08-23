namespace TextGame
{
    public class GameFramewark
    {
        private bool _isGameLive = false;
        private bool _isPressESC = false;
        private bool _isPlayGame = false;

        public bool IsGameLive
        {
            get { return _isGameLive; }
        }

        public void Initilize()
        {
            _isGameLive = true;
        }

        public void CheckInputKey()
        {
            var keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Q && _isPressESC == false)
            {
                Console.WriteLine("Are U sure  is GameOver? Press Y or N");
                _isPressESC = true;
            }

            if (keyInfo.Key == ConsoleKey.Spacebar && _isPlayGame == false)
            {
                Console.WriteLine("가위바위 보를 하겠습니다  원하는 것을 내보세요, 1 가위, 2 바위, 3 보");
                _isPlayGame = true;
            }

            if (keyInfo.Key == ConsoleKey.D1 && _isPlayGame)
            {
                Console.WriteLine("가위 바위 보의 결과는 ");
                _isPlayGame = false;
            }
            else if (keyInfo.Key == ConsoleKey.D2 && _isPlayGame)
            {
                Console.WriteLine("가위 바위 보의 결과는 ");
                _isPlayGame = false;
            }
            else if (keyInfo.Key == ConsoleKey.D3 && _isPlayGame)
            {
                Console.WriteLine("가위 바위 보의 결과는 ");
                _isPlayGame = false;
            }

            if (_isPressESC)
            {
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Good Bye");
                    _isGameLive = false;
                }

                if (keyInfo.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Keep Going");
                    _isPressESC = false;
                }
            }
        }


        private void PlayGame()
        {

        }



    }
}
