using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private bool isPlayerBullet;


    private void Start()
    {
        isPlayerBullet = gameObject.CompareTag("Player Gun") ? true : false;
    }

    private void Update()
    {
        if (transform.position.y >= 5.5f)
        {
            Destroy(gameObject);
        }

        
    }

    private void FixedUpdate()
    {

        //transform.Translate(new Vector2(transform.position.x, 1) * speed * Time.deltaTime);
        if (isPlayerBullet)
        {
            movePlayerBullet();
        }
        else
        {
            moveEnemyBullet();
        }
    }

    private void movePlayerBullet()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, 5.2f), speed * Time.deltaTime);
    }

    private void moveEnemyBullet()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -5.2f), speed * Time.deltaTime);
    }
}
