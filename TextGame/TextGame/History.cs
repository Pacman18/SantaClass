using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public class History
    {
        private List<int> NumberHistory;

        public List<int> GetNumberList()
        {
            return NumberHistory;
        }

        public void ShowList()
        {
            for(int i = 0;  i < NumberHistory.Count; i++)
            {
                Console.WriteLine(NumberHistory[i]);    
            }

        }

        public void AddNumber(int number)
        {
            NumberHistory.Add(number);
        }

        public History()
        {
            NumberHistory = new List<int>();
        }
            


    }
}
