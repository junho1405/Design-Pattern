using UnityEngine;
using System;

public class EventTester : MonoBehaviour
{
    private void OnEnable()
    {
        // 이벤트 등록 (구독)
        EventBus.Subscribe(Condition.Start, OnStart);
        EventBus.Subscribe(Condition.Pause, OnPause);
        EventBus.Subscribe(Condition.Exit, OnExit);
    }

    private void OnDisable()
    {
        // 이벤트 해제
        EventBus.Unsubscribe(Condition.Start, OnStart);
        EventBus.Unsubscribe(Condition.Pause, OnPause);
        EventBus.Unsubscribe(Condition.Exit, OnExit);
    }

    private void Update()
    {
        // 키보드 입력으로 이벤트 발행 (Publish)
        if (Input.GetKeyDown(KeyCode.S))
            EventBus.Publish(Condition.Start);

        if (Input.GetKeyDown(KeyCode.P))
            EventBus.Publish(Condition.Pause);

        if (Input.GetKeyDown(KeyCode.E))
            EventBus.Publish(Condition.Exit);
    }

    // 실제로 실행될 함수들
    void OnStart() => Debug.Log("[EventTester] START 이벤트 실행!");
    void OnPause() => Debug.Log("[EventTester] PAUSE 이벤트 실행!");
    void OnExit() => Debug.Log("[EventTester] EXIT 이벤트 실행!");
}
