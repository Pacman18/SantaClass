using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A ������ 5�ʸ��� �����ؾ��ϴ� ���� , B ������ A�� 3�� ����Ǹ� B�� �ѹ� ����Ǵ� ����

public class TestBehaviorAI : MonoBehaviour
{
    private BehaviorNode _rootNode; 

    private int _accApattern = 0; // A ���� ���� Ƚ��     

    private float _accTime = 0; // �ð� ���� üũ�� ����

    void Start()
    {

        var list = new List<BehaviorNode>();

        list.Add(CreateAPattern());
        list.Add(CreateBPattern());

        _rootNode = new SelectorNode(list);

    }

    void Update()
    {
        if(_rootNode != null)
            _rootNode.Execute();

        _accTime += Time.deltaTime;

    }

    // AAA �� 5�ʰ� ������  �����ϰ�
    private BehaviorNode CreateAPattern()
    {
        SequenceNode sequence = new SequenceNode();

        // 5�ʰ� ������ true
        ConditionNode acondition = new ConditionNode(()=>
        {
            return _accTime >= 5;
        });  

        // ���� ADD �������� �ϴ� �κ� 
        sequence.AddSequence(acondition);

        DoActionNode aAction = new DoActionNode(OnAAADoAction);

        // ���� ADD Do�� �ϴ� �κ� 
        sequence.AddSequence(aAction);

        return sequence;
    }

     // B �� A�� 3�� �Ҷ����� �����Ѵ�. 
    private BehaviorNode CreateBPattern()
    {
        SequenceNode sequence = new SequenceNode();

        // 5�ʰ� ������ true
        ConditionNode acondition = new ConditionNode(()=>
        {
            return _accApattern >= 3;
        });  

        // selector�� ADD �������� �ϴ� �κ� 
        sequence.AddSequence(acondition);

        DoActionNode aAction = new DoActionNode(OnBBBDoAction);

        // selector�� ADD Do�� �ϴ� �κ� 
        sequence.AddSequence(aAction);

        return sequence;
    }


    // AAA �����ϋ� �׼� 
    private void OnAAADoAction()
    {
        Debug.Log("OnAAADoAction  AAAAA : " + _accApattern );

        _accTime = 0;

        _accApattern++;
    }

     // BBB �����϶� �׼�  
    private void OnBBBDoAction()
    {
        Debug.Log("OnBBBDoAction : " + _accApattern);
        _accApattern = 0 ;
    }

    // ���ڴ� �׼� 
    private void OnSleepAction()
    {

        Debug.Log("OnSleepAction");
    }



}
