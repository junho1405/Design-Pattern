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
            Debug.LogWarning("M4: bulletPrefab 또는 firePoint가 설정되지 않았습니다!");
            return;
        }

        GameObject bullet = Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet b = bullet.GetComponent<Bullet>();
        if (b != null)
        {
            b.speed = bulletSpeed;
            b.lifeTime = bulletLifeTime;
        }

        Debug.Log("M4 발사!");
    }
}
