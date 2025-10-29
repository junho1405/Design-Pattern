using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [Header("Prefab & Target Settings")]
    [SerializeField] private GameObject robot;
    [SerializeField] private Transform target;

    [Header("Spawn Settings")]
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private Vector2 rangeX = new Vector2(-8f, 8f);
    [SerializeField] private Vector2 rangeZ = new Vector2(-8f, 8f);

    [Header("Speed Settings")]
    [SerializeField] private Vector2 speedRange = new Vector2(1f, 4f);

    private void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        while (true)
        {
            yield return CoroutineManager.WaitForSeconds(spawnInterval);

            float randomX = Random.Range(rangeX.x, rangeX.y);
            float randomZ = Random.Range(rangeZ.x, rangeZ.y);
            Vector3 spawnPos = new Vector3(randomX, 0f, randomZ);

            GameObject newRobot = Instantiate(robot, spawnPos, Quaternion.identity);

            RobotFollower follower = newRobot.GetComponent<RobotFollower>();
            if (follower != null)
            {
                follower.SetTarget(target);
                float randomSpeed = Random.Range(speedRange.x, speedRange.y);
                follower.SetSpeed(randomSpeed);
            }
        }
    }
}
