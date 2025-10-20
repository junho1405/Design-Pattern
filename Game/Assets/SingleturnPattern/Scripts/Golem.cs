using UnityEngine;

public class Golem : MonoBehaviour
{
    public float scaleSpeed = 1f; // ũ�� ��ȭ �ӵ�
    public float scaleRange = 1f; // ũ�� ��ȭ ���� (0~1)

    void Update()
    {
        float scale = Mathf.PingPong(Time.time * scaleSpeed, scaleRange);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
