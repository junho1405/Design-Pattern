using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // ���� ���ٿ� �̱��� �ν��Ͻ�
    public static bool isPaused = false;

    private void Awake()
    {
        // �ν��Ͻ��� �̹� �����Ѵٸ� ���� ���� �� �ı�
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �� �̵��ص� ����
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // ���� ���� �͸� �ı�
        }
    }

    public void Pause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("�Ͻ����� ON");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("�Ͻ����� OFF");
        }
    }
}
