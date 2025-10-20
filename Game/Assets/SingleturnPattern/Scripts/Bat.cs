using UnityEngine;

public class Bat : MonoBehaviour
{
    public float moveSpeed = 1f; // 이동 속도
    public float moveRange = 1f; // 이동 범위

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        float y = Mathf.PingPong(Time.time * moveSpeed, moveRange * 2) - moveRange;
        transform.position = new Vector3(transform.position.x, startY + y, transform.position.z);
    }
}
