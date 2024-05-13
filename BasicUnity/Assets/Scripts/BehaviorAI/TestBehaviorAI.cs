using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A 패턴은 5초마다 실행해야하는 조건 , B 패턴은 A가 3번 실행되면 B가 한번 실행되는 조건

public class TestBehaviorAI : MonoBehaviour
{
    private BehaviorNode _rootNode; 

    private int _accApattern = 0; // A 패턴 실행 횟수     

    private float _accTime = 0; // 시간 누적 체크용 변수

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

    // AAA 는 5초가 넘으면  실행하고
    private BehaviorNode CreateAPattern()
    {
        SequenceNode sequence = new SequenceNode();

        // 5초가 넘으면 true
        ConditionNode acondition = new ConditionNode(()=>
        {
            return _accTime >= 5;
        });  

        // 조건 ADD 시퀀스를 하는 부분 
        sequence.AddSequence(acondition);

        DoActionNode aAction = new DoActionNode(OnAAADoAction);

        // 조건 ADD Do를 하는 부분 
        sequence.AddSequence(aAction);

        return sequence;
    }

     // B 는 A가 3번 할때마다 실행한다. 
    private BehaviorNode CreateBPattern()
    {
        SequenceNode sequence = new SequenceNode();

        // 5초가 넘으면 true
        ConditionNode acondition = new ConditionNode(()=>
        {
            return _accApattern >= 3;
        });  

        // selector에 ADD 시퀀스를 하는 부분 
        sequence.AddSequence(acondition);

        DoActionNode aAction = new DoActionNode(OnBBBDoAction);

        // selector에 ADD Do를 하는 부분 
        sequence.AddSequence(aAction);

        return sequence;
    }


    // AAA 조건일떄 액션 
    private void OnAAADoAction()
    {
        Debug.Log("OnAAADoAction  AAAAA : " + _accApattern );

        _accTime = 0;

        _accApattern++;
    }

     // BBB 조건일때 액션  
    private void OnBBBDoAction()
    {
        Debug.Log("OnBBBDoAction : " + _accApattern);
        _accApattern = 0 ;
    }

    // 잠자는 액션 
    private void OnSleepAction()
    {

        Debug.Log("OnSleepAction");
    }



}
