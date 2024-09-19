using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    
    // Start 누르면 이제 시작화면 나와서 선택하고 

    // 게임이 바로 시작하게 만든다 ( 시간제한 카운트다운 5초 이후)

    // 타이머를 만들고 타임어택 모드로 게임을 만든다 

    // TimeSpan 타입으로 시간을 체크하는것 보여줘도 되고 ( 시간 직접 계산도 괜찮다. )

    // 캐릭터 움직이는것 만들고 ( 좌우 이동, ) -- 두발까지만 쏘는것으로 작업한다. 

    // 스프라이트 2장 , 총알용 2장 

    // 총알 쏘는것 까지 만들어보자.     

    // 이제 충돌처리 AABB 설명하고, 로직을  ChatGPT로 가져와보자  
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            UIFadeInOut ui = UIManager.Instance.CreatePage<UIFadeInOut>();

            if(ui != null)
                ui.StartFadeIn();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            UIManager.Instance.RemovePage<UIFadeInOut>();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(TestCoroutine());            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(LastStudyFunction());
        }

        // 실행은 KeyCode를 눌렀을때 
        // 코루틴 코드를 활용해서 
        // 시작하자마 UI매니저를 통해서 UIFadeInout페이를 만들고
        // 3초있다가 UIStartPage를 만들어보자. 
        // 3초있다가 UIStartPage를 삭제

    }

    private IEnumerator LastStudyFunction()
    {
        UIManager.Instance.CreatePage<UIFadeInOut>();

        yield return new WaitForSeconds(3);

        UIManager.Instance.CreatePage<UIStartPage>();

        yield return new WaitForSeconds(3);

        UIManager.Instance.RemovePage<UIStartPage>();
    }

    private IEnumerator TestCoroutine()
    {
        Debug.Log("First");
        yield return new WaitForSeconds(3);
        Debug.Log("Second");
        yield return new WaitForSeconds(3);
        Debug.Log("Third");
    }


}
