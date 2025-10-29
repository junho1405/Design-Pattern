using UnityEngine;

public class RobotFollower : MonoBehaviour
{
    private Transform target;
    private Animator animator;

    [Header("Movement Settings")]
    public float moveSpeed = 2f;   // ���� �κ��� ���� �ӵ�
    public float stopDistance = 1f;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    // ���� �ӵ� ����
    public void SetSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (target == null) return;

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > stopDistance)
        {
            // �̵�
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // ���� �������� ��ǥ �ٶ󺸱�
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Euler(0, lookRotation.eulerAngles.y, 0);

            if (animator != null)
                animator.Play("Run");
        }
        else
        {
            if (animator != null)
                animator.Play("StaticIdle");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"�÷��̾�� �浹 �� �κ� ������ (�ӵ�:{moveSpeed:F1})");
            Destroy(gameObject, 0.3f); // 0.3�� �� ���� ���� (Hierarchy������ �����)
        }
    }
}
