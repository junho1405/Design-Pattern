using UnityEngine;

public class EventManager : MonoBehaviour
{
    private void Start()
    {
        // ����: 2�ʸ��� �̺�Ʈ ����
        InvokeRepeating("PublishRandomEvent", 2f, 3f);
    }

    void PublishRandomEvent()
    {
        string[] events = { "START", "PAUSE", "EXIT" };
        string randomEvent = events[Random.Range(0, events.Length)];

        Debug.Log($"[Publisher] Publish Event: {randomEvent}");
        EventBus.Publish(randomEvent);
    }
}
