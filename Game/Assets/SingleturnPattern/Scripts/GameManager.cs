using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // 전역 접근용 싱글톤 인스턴스
    public static bool isPaused = false;

    private void Awake()
    {
        // 인스턴스가 이미 존재한다면 새로 생긴 건 파괴
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 이동해도 유지
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // 새로 생긴 것만 파괴
        }
    }

    public void Pause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("일시정지 ON");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("일시정지 OFF");
        }
    }
}
