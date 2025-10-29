using UnityEngine;

// �ö��̿���Ʈ ���丮: �������� �����ϸ鼭 �κ� ����
public class RobotFactory
{
    private RobotFlyweight flyweight;

    public RobotFactory(RobotFlyweight flyweight)
    {
        this.flyweight = flyweight;
    }

    public GameObject Create(Vector3 position)
    {
        // �������� ����, ��ġ�� �ٸ��� ����
        return Object.Instantiate(flyweight.prefab, position, Quaternion.identity);
    }
}
