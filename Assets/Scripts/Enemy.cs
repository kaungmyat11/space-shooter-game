using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Spaceship
{
    private float timer;

    [SerializeField] private float yPosition;

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
        if (other.gameObject.tag == "Player Gun" && transform.position.y <= 4.8f)
        {
            Debug.Log("Player bullet hits me");
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            Destroy(other.gameObject);
        }
    }

    private void MoveEnemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, yPosition), moveSpeed * Time.deltaTime);
    }
}
