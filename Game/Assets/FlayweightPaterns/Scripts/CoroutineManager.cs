using System.Collections.Generic;
using UnityEngine;

public static class CoroutineManager
{
    private static Dictionary<float, WaitForSeconds> waitDictionary = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds WaitForSeconds(float time)
    {
        if (waitDictionary.ContainsKey(time))
            return waitDictionary[time];

        WaitForSeconds wait = new WaitForSeconds(time);
        waitDictionary.Add(time, wait);
        return wait;
    }
}
