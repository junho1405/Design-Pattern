using UnityEngine;

public class EventManager : MonoBehaviour
{
    private void Start()
    {
        // 예시: 2초마다 이벤트 발행
        InvokeRepeating("PublishRandomEvent", 2f, 3f);
    }

    void PublishRandomEvent()
    {
        string[] events = { "START", "PAUSE", "EXIT" };
        string randomEvent = events[Random.Range(0, events.Length)];

        Debug.Log($"[Publisher] Publish Event: {randomEvent}");
        EventBus.Publish(Condition.Exit);
    }

    internal static void Subscibe(Condition start)
    {
        throw new System.NotImplementedException();
    }

    internal static void Subscibe(Condition start, System.Action enableAnimator)
    {
        throw new System.NotImplementedException();
    }
}
