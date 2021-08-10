using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float xBound = 2.5f;

    private float timer;
    [SerializeField] private float maxTimer;

    private float xPosition;
    private Vector3 spawnPosition;
    [SerializeField] private Transform enemyPrefab;


    private void Start()
    {
        timer = maxTimer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = maxTimer;
            double randomNum = System.Math.Round(Random.Range(-xBound, xBound), 1);
            xPosition = (float) randomNum;
            spawnPosition = new Vector3(xPosition, 5.3f, 0);
            SpawnEnemy(spawnPosition);
        }
    }

    private void SpawnEnemy(Vector3 spawnPosition)
    {
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
