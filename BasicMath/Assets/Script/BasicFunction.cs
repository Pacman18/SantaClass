using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFunction : MonoBehaviour
{
    // Scene에 대한 것을 설명하고 빈 오브젝트를 만듭니다. 
    // 빈 오브젝트를 클릭하고 인스펙터 창에 대한 설명을 합니다. 

    // 인스펙터의 좌표 값을 보여주면서 X, Y , Z 에 대한 좌표계 설명을 합니다. 

    // 3D 직교 좌표계를 사용합니다. 
    // 좌표계는 World 좌표계 Local좌표계 두가지로 구분 - 기준을 어디로 두느냐 차이 설명 
    
    // 기준에 대한 정의가 필요 ---->

    // 회전값까지 계산되면 극좌표계라고 함 
    // 회전을 계산하는것으 Rotation 필드에 정해져있으면 Scale 값이 크기로 정해진다.

    // Start is called before the first frame update
    void Start()
    {
        // 시작하면 로그가 찍히는 에디터의 위치를 알려준다. 
        // Console 창에 어떤 로그가 찍히는지 충분히 인지 시킨다. 
        Debug.Log("첫번째 로그 ");

        
        // 자 로그가 찍혔으면 이제 유니티의 라이프 사이클에 대해서 설명한다. 
        // 인터넷 창을 켜고 "유나타 이벤트 함수의 실행순서  " 이라고 검색하자 
        // https://docs.unity3d.com/kr/2019.4/Manual/ExecutionOrder.html
        // LifeCycle 프로젝트를 켜주고 라이프 사이클이 무엇인지 이해 시킨다. 


        // 기대사항 : 이벤트 함수의 원리를 알았다면 내가 어떤 코드를 어떤 곳에 어떻게 불리게 할지 잘 알 수 있다.

        // 이벤트 함수에 로그를 넣어서 로그를 찍어보자.


        // 게임오브젝트에 스크립트 즉 컴포넌트가 붙어서 돌아가는 과정을 설명한다. 
        // 외적으로 눈에 보이는 게임오브젝트가 하나의  클래스이고 
        // 게임 오브젝트 콤포넌트가 붙은 컴포넌트들을 멤버로 가지고 있으면서 
        // 필요한 함수들가져다 쓸 수 있게 설계된것 을 그려주면 된다.

        // 키 입력 받는 if를 제일 먼저 실행해보자 

        // 게임 오브젝트의 이름을 가져와 보자. 
        
        // 트랜스폼에 대해서 설명한다. 현재 내 위치를 가리키는것이 어떤 것인지 확인시킨다. 
        // 직접 좌표계로 이동시켜 보자         
        // OnDrawGizmo 
        // 직접 벡터를 그려서 설명함 

        // 벡터 연산 더하기를 그려보는것도 해보자
        
        // 벡터 연산 빼기를 해보자 

        // 이번엔 키를 입력받아서 변수를 바꿔보자.---> 각도 변수 angle를 만들어서 눈으로 직접 확인시킨다. 

        // 벡터의 foward , right 를 알려준다.  default 값이 어떤 값인지는 중요하게 생각해야한다.
        
        // 벡터의 연산을 할때 noramlize 죽 단위화를 한 이후에 연산하는 방법을 잘 알려준다. 

        // 벡터에 대한것을 알려줄때 회전도, 더하는것도, 원점으로 이동한 다음에 회전 이후 해당 위치로 바꾸는것으로 알려준다.

        // Input S 부분에 추가하였음 .


    }

    int angle = 0; // 3가지 축이 있는것을 인지하고 있어야한다.

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            angle++;
            Debug.Log("Input.A : " + angle);
        }

        // Gizmo를 보여준 다음에 현재 트랜스 폼이랑 맞추는 작업 -> 하위에 Foward가 어딘지를 두고 돌릴것 
        // Look 벡터를 추가로 알려주는것이 맞을듯하다, 
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Input.A : " + angle);

            transform.rotation = Quaternion.Euler(0,angle,0);
        }
        
    }

    private void OnDrawGizmos()
    {
        // Gizmos의 색상을 설정합니다.
        Gizmos.color = Color.red;
        
        // 시작점과 끝점을 설정합니다.
        Vector3 startPoint = Vector3.zero; // (0,0,0)
        Vector3 endPoint = new Vector3(0, 0, 2); // (1,1,1)

        // 
        Vector3 rotate = Quaternion.Euler(0,angle,0) * endPoint;        


        
        // 선을 그립니다.
        Gizmos.DrawLine(startPoint, rotate);
    }


    // 라이프 사이클을 이해시키면서 여기까지 들어오는것을 확인 시켜준다.
    void OnDestroy()
    {
        Debug.Log("OnDestroy");
        
    }
}
