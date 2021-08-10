using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 screenBound;
    private float playerWidth;
    private float playerHeight;

    private Vector3 inputPosition;
    private Camera mainCamera;

    [SerializeField] private float maxTimer;
    private float timer;

    [SerializeField] private Transform weaponPrefab;

    private void Start()
    {
        mainCamera = Camera.main;
        timer = maxTimer;

        screenBound = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z)); // 2.8, 5.0
        playerWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("Weapon Shoot");
        //    Instantiate(weaponPrefab, transform.position, Quaternion.identity);
        //}

        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            timer = maxTimer;
            Instantiate(weaponPrefab, transform.position, Quaternion.identity);
        }
    }

    private void LateUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        inputPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        inputPosition.x = Mathf.Clamp(inputPosition.x, -screenBound.x + playerWidth, screenBound.x - playerWidth);
        inputPosition.y = Mathf.Clamp(inputPosition.y, -screenBound.y + playerHeight, screenBound.y - playerHeight);
        inputPosition.z = 0;
        transform.position = inputPosition;
    }
}
