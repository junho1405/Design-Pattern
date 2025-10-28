using UnityEngine;

public abstract class State : MonoBehaviour
{
    public abstract void Enter(Character character);
    public abstract void Update(Character character);
    public abstract void Exit(Character character);
}
