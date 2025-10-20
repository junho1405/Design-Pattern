using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPaused = false;

    public void Pause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("게임 일시정지됨");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("게임 재개됨");
        }
    }
}
