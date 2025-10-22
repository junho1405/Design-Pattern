using UnityEngine;

public class Client1 : MonoBehaviour
{
    private void OnEnable()
    {
        // ���� �ڵ� (�߸��� �κ�)
        // EventBus.Subscribe("START", OnStartEvent);
        // EventBus.Subscribe("EXIT", OnExitEvent);

        // ������ �ڵ� 
        EventBus.Subscribe(Condition.Start, OnStartEvent);
        EventBus.Subscribe(Condition.Exit, OnExitEvent);
    }

    private void OnDisable()
    {
        // EventBus.Unsubscribe("START", OnStartEvent);
        // EventBus.Unsubscribe("EXIT", OnExitEvent);

        EventBus.Unsubscribe(Condition.Start, OnStartEvent);
        EventBus.Unsubscribe(Condition.Exit, OnExitEvent);
    }

    void OnStartEvent()
    {
        Debug.Log("[Client1] START �̺�Ʈ ó��");
    }

    void OnExitEvent()
    {
        Debug.Log("[Client1] EXIT �̺�Ʈ ó��");
    }
}
