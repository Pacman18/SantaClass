using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceMySelf.Body
{
    public class Human
    {
        public string Name;
        public int Age;
        public float Height;
        public bool IsMan;


        // 생성자 
        public Human()
        {

        }

        // 생성자 2
        public Human(string name)
        {
            this.Name = name;
        }
    }
}
