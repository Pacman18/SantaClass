using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroduceMySelf.Body;

namespace IntroduceMySelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World ");
            Console.WriteLine("이름을 입력해 주세요.");
            var inputName = Console.ReadLine();

            Human mybody = new Human(inputName);

            Console.WriteLine("내 이름은: " + mybody.Name);

            Console.ReadLine();


            bool front = true;
            int index = 0;

            string canvas = "canvas : ";

            while(true)
            {
                

                if(front)
                {
                    Console.WriteLine("1번에 그림 그림 : " + index + " 2번 도화지 지우기");
                    canvas = "canvas : " + 1;

                }
                else
                {
                    Console.WriteLine("2번에 그림 그림 : " + index + " 1번 도화지 지우기");
                    canvas = "canvas : " + 2;

                }

                Console.WriteLine("Canvas 그려주기 : " + canvas);

                index++;

                front = !front;

            }

        }
    }
}
