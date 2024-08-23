using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardTextGame
{
    public class InputManager
    {
        public delegate void OnGameStart();

        private OnGameStart _onGameStart;

        public void OnGameStartAddListener(OnGameStart callback)
        {
            _onGameStart = callback;
        }

        public void Update()
        {

        }

        
        // delegate가 없이 이벤트 메세지를 쏘는것을 먼저 선보인다음에 
        // Delegate를 활용한 설계 방식을 보여준다 .
        // 관리 주체가 자기자신이 되는것인지 ,  다른 클래스가 나를 관리하는것인지 ( 절차 지향적 )



    }
}
