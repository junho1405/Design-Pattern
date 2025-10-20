using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float rotationSpeed = 60f; // 회전 속도 (초당 각도)
    public float rotationRange = 45f; // 좌우 회전 각도

    void Update()
    {
        float angle = Mathf.PingPong(Time.time * rotationSpeed, rotationRange * 2) - rotationRange;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
