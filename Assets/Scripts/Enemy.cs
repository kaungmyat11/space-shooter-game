using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Spaceship
{
    private float timer;

    private void Start()
    {
        timer = shootTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = shootTime;
            Shoot(transform.position);
        }
    }

    private void FixedUpdate() 
    {
        MoveEnemy();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player Gun")
        {
            Debug.Log("Player bullet hits me");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    private void MoveEnemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -5.6f), moveSpeed * Time.deltaTime);
    }
}
