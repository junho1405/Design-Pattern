using UnityEngine;

public class AA12 : Wepon
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 12f;
    public float bulletLifeTime = 1.2f;

    public override void Launch()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("AA12: bulletPrefab 또는 firePoint가 설정되지 않았습니다!");
            return;
        }

        GameObject bullet = Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet b = bullet.GetComponent<Bullet>();
        if (b != null)
        {
            b.speed = bulletSpeed;
            b.lifeTime = bulletLifeTime;
        }

        Debug.Log("AA12 발사!");
    }
}
