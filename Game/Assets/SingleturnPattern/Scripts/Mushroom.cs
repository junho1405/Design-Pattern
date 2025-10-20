using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float rotationSpeed = 60f; // ȸ�� �ӵ� (�ʴ� ����)
    public float rotationRange = 45f; // �¿� ȸ�� ����

    void Update()
    {
        float angle = Mathf.PingPong(Time.time * rotationSpeed, rotationRange * 2) - rotationRange;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }
}
