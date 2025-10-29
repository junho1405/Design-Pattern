using UnityEngine;

public class RobotFollower : MonoBehaviour
{
    private Transform target;
    private Animator animator;

    [Header("Movement Settings")]
    public float moveSpeed = 2f;   // 개별 로봇의 실제 속도
    public float stopDistance = 1f;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    // 개별 속도 설정
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
            // 이동
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // 정면 기준으로 목표 바라보기
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
            Debug.Log($"플레이어와 충돌 → 로봇 삭제됨 (속도:{moveSpeed:F1})");
            Destroy(gameObject, 0.3f); // 0.3초 후 완전 삭제 (Hierarchy에서도 사라짐)
        }
    }
}
