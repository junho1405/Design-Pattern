using System;
using System.Collections.Generic;

public static class EventBus
{
    // 이벤트 이름과 콜백 리스트를 매핑
    private static Dictionary<string, Action> eventTable = new Dictionary<string, Action>();

    // 구독 (Subscribe)
    public static void Subscribe(string eventName, Action callback)
    {
        if (eventTable.ContainsKey(eventName))
            eventTable[eventName] += callback;
        else
            eventTable[eventName] = callback;
    }

    // 구독 해제 (Unsubscribe)
    public static void Unsubscribe(string eventName, Action callback)
    {
        if (eventTable.ContainsKey(eventName))
        {
            eventTable[eventName] -= callback;
            if (eventTable[eventName] == null)
                eventTable.Remove(eventName);
        }
    }

    // 발행 (Publish)
    public static void Publish(string eventName)
    {
        if (eventTable.ContainsKey(eventName))
        {
            eventTable[eventName]?.Invoke();
        }
    }
}
