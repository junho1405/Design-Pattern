using UnityEngine;

public class Client3 : MonoBehaviour
{
    private void OnEnable()
    {
        EventBus.Subscribe("START", OnStartEvent);
        EventBus.Subscribe("EXIT", OnExitEvent);
    }

    private void OnDisable()
    {
        EventBus.Unsubscribe("START", OnStartEvent);
        EventBus.Unsubscribe("EXIT", OnExitEvent);
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
