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
}
