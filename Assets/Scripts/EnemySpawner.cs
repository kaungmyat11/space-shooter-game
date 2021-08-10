using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float xBound = 2.5f;

    private float timer;
    [SerializeField] private float maxTimer;

    private float randomNumber;
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
            randomNumber = Random.Range(-xBound, xBound);
            Debug.Log(randomNumber);
        }
    }

    private void SpawnEnemy()
    {

    }
}
