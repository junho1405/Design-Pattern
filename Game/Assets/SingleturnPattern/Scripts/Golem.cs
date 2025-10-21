using UnityEngine;

public class Golem : MonoBehaviour
{
    public float scaleSpeed = 1f;
    public float scaleRange = 1f;

    void Update()
    {
        if (GameManager.isPaused) return;

        float scale = Mathf.PingPong(Time.time * scaleSpeed, scaleRange);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
