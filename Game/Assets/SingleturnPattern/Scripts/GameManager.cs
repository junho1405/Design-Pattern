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
            Debug.Log("���� �Ͻ�������");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("���� �簳��");
        }
    }
}
