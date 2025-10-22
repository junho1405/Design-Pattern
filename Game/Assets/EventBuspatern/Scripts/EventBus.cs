using System;
using System.Collections.Generic;
using UnityEngine;

//  �̺�Ʈ�� �߾ӿ��� �����ϴ� Ŭ����
public static class EventBus
{
    // Condition(�̺�Ʈ ����) �� Action(������ �Լ�)
    private static Dictionary<Condition, Action> eventTable = new Dictionary<Condition, Action>();

    // --- ���� ---
    public static void Subscribe(Condition condition, Action action)
    {
        if (eventTable.ContainsKey(condition))
        {
            // �̹� �ش� Ű�� ������ �����̱�
            eventTable[condition] += action;
            Debug.Log($"[EventBus] {condition} �̺�Ʈ�� Action �߰���.");
        }
        else
        {
            // ������ ���� ���
            eventTable[condition] = action;
            Debug.Log($"[EventBus] {condition} �̺�Ʈ �ű� ��ϵ�.");
        }
    }

    // --- ���� ���� ---
    public static void Unsubscribe(Condition condition, Action action)
    {
        if (eventTable.ContainsKey(condition))
        {
            eventTable[condition] -= action;
            if (eventTable[condition] == null)
                eventTable.Remove(condition);
        }
    }

    // --- �̺�Ʈ ���� ---
    public static void Publish(Condition condition)
    {
        if (eventTable.ContainsKey(condition))
        {
            Debug.Log($"[EventBus] {condition} �̺�Ʈ �����!");
            eventTable[condition]?.Invoke();
        }
        else
        {
            Debug.LogWarning($"[EventBus] {condition} �̺�Ʈ�� ��ϵ� �Լ� ����!");
        }
    }
}
