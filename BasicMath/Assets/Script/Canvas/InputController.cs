using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{




    // ��ǲ�� ���� �����Ѵ�.
    void Update()
    {
        bool inputTrue = Input.GetKeyDown(KeyCode.A);

        if(inputTrue)
        {
            // ���⼭ �Է� �Ǵ� ���� �������̺� �� �� ���� 
            Debug.Log("A Ű�� �Էµ� ");
        }
        
    }
}
