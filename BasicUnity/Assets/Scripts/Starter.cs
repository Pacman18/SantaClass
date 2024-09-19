using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    
    // Start ������ ���� ����ȭ�� ���ͼ� �����ϰ� 

    // ������ �ٷ� �����ϰ� ����� ( �ð����� ī��Ʈ�ٿ� 5�� ����)

    // Ÿ�̸Ӹ� ����� Ÿ�Ӿ��� ���� ������ ����� 

    // TimeSpan Ÿ������ �ð��� üũ�ϴ°� �����൵ �ǰ� ( �ð� ���� ��굵 ������. )

    // ĳ���� �����̴°� ����� ( �¿� �̵�, ) -- �ι߱����� ��°����� �۾��Ѵ�. 

    // ��������Ʈ 2�� , �Ѿ˿� 2�� 

    // �Ѿ� ��°� ���� ������.     

    // ���� �浹ó�� AABB �����ϰ�, ������  ChatGPT�� �����ͺ���  
    
    
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

        // ������ KeyCode�� �������� 
        // �ڷ�ƾ �ڵ带 Ȱ���ؼ� 
        // �������ڸ� UI�Ŵ����� ���ؼ� UIFadeInout���̸� �����
        // 3���ִٰ� UIStartPage�� ������. 
        // 3���ִٰ� UIStartPage�� ����

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
