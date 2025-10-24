using UnityEngine;

public class SAIGA12 : Wepon
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 15f;
    public float bulletLifeTime = 1.5f;

    public override void Launch()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("SAIGA12: bulletPrefab �Ǵ� firePoint�� �������� �ʾҽ��ϴ�!");
            return;
        }

        GameObject bullet = Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet b = bullet.GetComponent<Bullet>();
        if (b != null)
        {
            b.speed = bulletSpeed;
            b.lifeTime = bulletLifeTime;
        }

        Debug.Log("SAIGA �߻�!");
    }
}
