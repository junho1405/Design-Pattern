using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private Text timeText;
    [SerializeField] private float time = 15.0f;   // 시작 시간 (초 단위)
    [SerializeField] private GameObject field;     // 제거할 오브젝트

    private float minute;
    private float second;
    private float millisecond;
    private bool isEnded = false;                  // 중복 Destroy 방지용

    void Update()
    {
        if (isEnded) return;  // 이미 종료됐으면 더 이상 실행하지 않음

        // 시간 감소
        if (time > 0)
        {
            time -= Time.deltaTime;
            if (time < 0) time = 0;
        }

        // 분, 초, 밀리초 계산
        minute = Mathf.Floor(time / 60);
        second = Mathf.Floor(time % 60);
        millisecond = Mathf.Floor((time * 100) % 100);

        // 시간 텍스트 표시
        timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minute, second, millisecond);

        // 시간이 0이 되면 Field 삭제
        if (time <= 0 && !isEnded)
        {
            isEnded = true;
            if (field != null)
            {
                Destroy(field);
                Debug.Log("[TimeManager] 시간이 다 되어 Field 오브젝트를 삭제했습니다.");
            }
        }
    }
}
