using System.ComponentModel;

namespace LifeCycle
{
    // 유니티 라이프 사이클이 어떻게 돌아가는지 이해하기 위한 C# 코드 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            UnityLife life = new UnityLife();

            life.Start();

            while (life.IsLive)
            {
                if (Console.KeyAvailable)
                {
                    var inputKey = Console.ReadKey();

                    if (inputKey.Key == ConsoleKey.Escape)
                    {
                        life.IsLive = false;
                    }
                }

                life.Update();
            }

            life.OnDestroy();

            Console.WriteLine("End Game");
        }

        public class UnityLife
        {
            public bool IsLive = false;

            public void Start()
            {
                IsLive = true;
                Console.WriteLine("Start");

            }

            public void Update()
            {
                Console.WriteLine("Update");
            }

            public void OnDestroy()
            {
                Console.WriteLine("OnDestroy");
            }
        }
    }
}