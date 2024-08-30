using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Timer
    {
        // async 는 비동기 작업을 나타내는 키워드 -> 함수 앞에 사용한다. 
        // Task 는 비동기 작업을 진행하는 클래스 . ->  백그라운드 작업, 대기작업에 사용 
        // await 는 기달려주는 작업 

        private int index = 0;
        private int waitIndex = 0;

        public async void WaitLoopNotify()
        {
            await LoopNotify_2();
        }

        public async Task LoopNotify()
        {
            index = 0;

            for (int i = 0; i < 10; i++)
            {
                await Task.Run(ShowLog);
            }            
        }

        public async Task LoopNotify_2()
        {
            waitIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                ShowWaitingLog();
            }
        }

        private void ShowLog()
        {
            index++;
            Console.WriteLine("비동기 작업 " + index);
        }

        private void ShowWaitingLog()
        {
            waitIndex++;
            Console.WriteLine("기달리는 비동기 작업 " + waitIndex);
        }


    }
}
