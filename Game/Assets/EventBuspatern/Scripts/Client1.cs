using UnityEngine;

public class Client1 : MonoBehaviour
{
    private void OnEnable()
    {
        // 기존 코드 (잘못된 부분)
        // EventBus.Subscribe("START", OnStartEvent);
        // EventBus.Subscribe("EXIT", OnExitEvent);

        // 수정된 코드 
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
        Debug.Log("[Client1] START 이벤트 처리");
    }

    void OnExitEvent()
    {
        Debug.Log("[Client1] EXIT 이벤트 처리");
    }
}
