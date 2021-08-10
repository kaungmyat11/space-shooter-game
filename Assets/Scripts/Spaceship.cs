using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] protected float health;
    [SerializeField] protected float shootTime;
    [SerializeField] protected float moveSpeed;

    [SerializeField] protected Transform weaponPrefab;

    protected void Shoot(Vector3 position)
    {
        Instantiate(weaponPrefab, position, Quaternion.identity);
    }
}
