using UnityEngine;

public class Publisher : MonoBehaviour
{
    void Start()
    {
        EventManager.Publish(Condition.Start);
    }

    public void pause()
    {
        EventManager.Publish(Condition.Pause);
    }    
}
