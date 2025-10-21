using System;
using System.Collections.Generic;

public static class EventBus
{
    // �̺�Ʈ �̸��� �ݹ� ����Ʈ�� ����
    private static Dictionary<string, Action> eventTable = new Dictionary<string, Action>();

    // ���� (Subscribe)
    public static void Subscribe(string eventName, Action callback)
    {
        if (eventTable.ContainsKey(eventName))
            eventTable[eventName] += callback;
        else
            eventTable[eventName] = callback;
    }

    // ���� ���� (Unsubscribe)
    public static void Unsubscribe(string eventName, Action callback)
    {
        if (eventTable.ContainsKey(eventName))
        {
            eventTable[eventName] -= callback;
            if (eventTable[eventName] == null)
                eventTable.Remove(eventName);
        }
    }

    // ���� (Publish)
    public static void Publish(string eventName)
    {
        if (eventTable.ContainsKey(eventName))
        {
            eventTable[eventName]?.Invoke();
        }
    }
}
