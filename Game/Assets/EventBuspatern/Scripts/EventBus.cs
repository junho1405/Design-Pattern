using System;
using System.Collections.Generic;
using UnityEngine;

//  이벤트를 중앙에서 관리하는 클래스
public static class EventBus
{
    // Condition(이벤트 종류) → Action(실행할 함수)
    private static Dictionary<Condition, Action> eventTable = new Dictionary<Condition, Action>();

    // --- 구독 ---
    public static void Subscribe(Condition condition, Action action)
    {
        if (eventTable.ContainsKey(condition))
        {
            // 이미 해당 키가 있으면 덧붙이기
            eventTable[condition] += action;
            Debug.Log($"[EventBus] {condition} 이벤트에 Action 추가됨.");
        }
        else
        {
            // 없으면 새로 등록
            eventTable[condition] = action;
            Debug.Log($"[EventBus] {condition} 이벤트 신규 등록됨.");
        }
    }

    // --- 구독 해제 ---
    public static void Unsubscribe(Condition condition, Action action)
    {
        if (eventTable.ContainsKey(condition))
        {
            eventTable[condition] -= action;
            if (eventTable[condition] == null)
                eventTable.Remove(condition);
        }
    }

    // --- 이벤트 발행 ---
    public static void Publish(Condition condition)
    {
        if (eventTable.ContainsKey(condition))
        {
            Debug.Log($"[EventBus] {condition} 이벤트 발행됨!");
            eventTable[condition]?.Invoke();
        }
        else
        {
            Debug.LogWarning($"[EventBus] {condition} 이벤트에 등록된 함수 없음!");
        }
    }
}
