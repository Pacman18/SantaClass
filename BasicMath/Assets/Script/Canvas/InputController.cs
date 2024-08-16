using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{




    // 인풋을 이제 연습한다.
    void Update()
    {
        bool inputTrue = Input.GetKeyDown(KeyCode.A);

        if(inputTrue)
        {
            // 여기서 입력 되는 것을 여러분이볼 수 가 있음 
            Debug.Log("A 키가 입력됨 ");
        }
        
    }
}
