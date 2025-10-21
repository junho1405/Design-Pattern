using UnityEngine;

public class Bat : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float moveRange = 1f;
    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        // 일시정지 상태면 아무 것도 하지 않음
        if (GameManager.isPaused) return;

        float y = Mathf.PingPong(Time.time * moveSpeed, moveRange * 2) - moveRange;
        transform.position = new Vector3(transform.position.x, startY + y, transform.position.z);
    }
}
