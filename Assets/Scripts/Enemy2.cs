using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private float speed = 2.5f;
    private float zigzagSpeed = 3f;
    private float amplitude = 1.5f;

    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        // Move down
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Zigzag left and right
        float xOffset = Mathf.Sin(Time.time * zigzagSpeed) * amplitude;
        transform.position = new Vector3(startX + xOffset, transform.position.y, 0);

        // Destroy when off screen
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

