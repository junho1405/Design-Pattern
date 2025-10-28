using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] Animator animator;

    public State currentState { get; private set; }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickUp();
        }

        Walk();
    }

    public void Walk()
    {
        currentState.Update(this);
    }


    public void SetState(State state)
    {
        this.currentState = state;
    }
    public void PickUp()
    {
        AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("PickUp")
            || animator.IsInTransition(0))
        {
            return;
        }

        // Trigger 이름 공백 제거
        animator.SetTrigger("PickUp");
    }
}
