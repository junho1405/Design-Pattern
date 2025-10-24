using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] Animator animator;
    //private bool isPaused = false;

    private void OnEnable()
    {
        EventManager.Subscibe(Condition.Start, EnableAnimator);
        EventManager.Subscibe(Condition.Start, DisanableAnimator);

    }

    private void EnableAnimator()
    {
        animator.enabled = true;
    }


    private void DisanableAnimator()
    {
        animator.enabled = false;
    }

    void Update()
    {


    }
}
