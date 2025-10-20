using UnityEngine;

public class Golem : MonoBehaviour
{
    public float scaleSpeed = 1f; // 크기 변화 속도
    public float scaleRange = 1f; // 크기 변화 범위 (0~1)

    void Update()
    {
        float scale = Mathf.PingPong(Time.time * scaleSpeed, scaleRange);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
