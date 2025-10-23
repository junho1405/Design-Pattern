using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Text timeText;
    [SerializeField] private float time = 15.0f;   // ���� �ð� (�� ����)
    [SerializeField] private GameObject field;     // ������ ������Ʈ

    private float minute;
    private float second;
    private float millisecond;
    private bool isEnded = false;                  // �ߺ� Destroy ������

    void Update()
    {
        if (isEnded) return;  // �̹� ��������� �� �̻� �������� ����

        // �ð� ����
        if (time > 0)
        {
            time -= Time.deltaTime;
            if (time < 0) time = 0;
        }

        // ��, ��, �и��� ���
        minute = Mathf.Floor(time / 60);
        second = Mathf.Floor(time % 60);
        millisecond = Mathf.Floor((time * 100) % 100);

        // �ð� �ؽ�Ʈ ǥ��
        timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minute, second, millisecond);

        // �ð��� 0�� �Ǹ� Field ����
        if (time <= 0 && !isEnded)
        {
            isEnded = true;
            if (field != null)
            {
                Destroy(field);
                Debug.Log("[TimeManager] �ð��� �� �Ǿ� Field ������Ʈ�� �����߽��ϴ�.");
            }
        }
    }
}
