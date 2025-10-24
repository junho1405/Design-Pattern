using UnityEngine;

public class M4 : Wepon
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float bulletLifeTime = 2f;

    public override void Launch()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("M4: bulletPrefab �Ǵ� firePoint�� �������� �ʾҽ��ϴ�!");
            return;
        }

        GameObject bullet = Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet b = bullet.GetComponent<Bullet>();
        if (b != null)
        {
            b.speed = bulletSpeed;
            b.lifeTime = bulletLifeTime;
        }

        Debug.Log("M4 �߻�!");
    }
}
