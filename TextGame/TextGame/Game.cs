using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public class Game
    {
        History _history;
        public void ShowLog()
        {
            Console.WriteLine("로그");            
        }

        public void AddRandomNumber()
        {
            Random random = new Random();
            int randNum = random.Next(0,100);
            

            _history.AddNumber(randNum);
            Console.WriteLine("randNum : " + randNum);

        }

        public void ShowAllNumber()
        {
            //var list = _history.GetNumberList();
            _history.ShowList();
        }

        public Game()
        {
            _history = new History();
        }
    }
}
