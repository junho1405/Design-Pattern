using UnityEngine;

// 플라이웨이트 팩토리: 프리팹을 공유하면서 로봇 생성
public class RobotFactory
{
    private RobotFlyweight flyweight;

    public RobotFactory(RobotFlyweight flyweight)
    {
        this.flyweight = flyweight;
    }

    public GameObject Create(Vector3 position)
    {
        // 프리팹은 공유, 위치만 다르게 생성
        return Object.Instantiate(flyweight.prefab, position, Quaternion.identity);
    }
}
