namespace TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   
            Console.WriteLine("Hello, World!");

            GameFramewark gameFramewark = new GameFramewark();

            gameFramewark.Initilize();

            while (gameFramewark.IsGameLive)
            {
                gameFramewark.CheckInputKey();
            }

        }
    }
}