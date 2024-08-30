using System;
using System.Threading.Tasks;

namespace TextGame
{
    internal class Program
    {
        // delegate 연습


        // 랜덤으로 

        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");

            Timer timeTester = new Timer();

            Console.WriteLine("Main Log 1");

            timeTester.WaitLoopNotify();

            await Task.Delay(3000);

            Console.WriteLine("Main Log 2");



            /*Game game = new Game();
            game.ShowLog();
            game.AddRandomNumber();
            game.AddRandomNumber();
            game.AddRandomNumber();
            game.ShowAllNumber(); // 누적된 넘버를 출력하는 함수를 만들어보세요*/

            Console.WriteLine("End");
        }
    }
}
