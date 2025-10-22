using UnityEngine;
using System;

public class EventTester : MonoBehaviour
{
    private void OnEnable()
    {
        // �̺�Ʈ ��� (����)
        EventBus.Subscribe(Condition.Start, OnStart);
        EventBus.Subscribe(Condition.Pause, OnPause);
        EventBus.Subscribe(Condition.Exit, OnExit);
    }

    private void OnDisable()
    {
        // �̺�Ʈ ����
        EventBus.Unsubscribe(Condition.Start, OnStart);
        EventBus.Unsubscribe(Condition.Pause, OnPause);
        EventBus.Unsubscribe(Condition.Exit, OnExit);
    }

    private void Update()
    {
        // Ű���� �Է����� �̺�Ʈ ���� (Publish)
        if (Input.GetKeyDown(KeyCode.S))
            EventBus.Publish(Condition.Start);

        if (Input.GetKeyDown(KeyCode.P))
            EventBus.Publish(Condition.Pause);

        if (Input.GetKeyDown(KeyCode.E))
            EventBus.Publish(Condition.Exit);
    }

    // ������ ����� �Լ���
    void OnStart() => Debug.Log("[EventTester] START �̺�Ʈ ����!");
    void OnPause() => Debug.Log("[EventTester] PAUSE �̺�Ʈ ����!");
    void OnExit() => Debug.Log("[EventTester] EXIT �̺�Ʈ ����!");
}
