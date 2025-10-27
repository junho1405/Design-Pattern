using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] int z;

    [SerializeField] Animator animator;

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
        x = (int)Input.GetAxisRaw("Horizontal");

        animator.SetInteger("X", x);
    }

    public void PickUp()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Pick Up") || animator.IsInTransition(0))
        {
            return;
        }

        animator.SetTrigger("Pick Up");
    }
}