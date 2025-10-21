using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float rotationSpeed = 60f;
    public float rotationRange = 45f;

    void Update()
    {
        if (GameManager.isPaused) return;

        float angle = Mathf.PingPong(Time.time * rotationSpeed, rotationRange * 2) - rotationRange;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
