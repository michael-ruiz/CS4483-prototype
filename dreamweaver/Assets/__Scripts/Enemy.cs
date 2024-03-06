using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject health;
    private Rigidbody2D rb;
    private float moveSpeed = 3f;
    private Vector2 direction;
    private bool pingPongMovement = true;
    private float currentX;
    public float rightMost;
    public float leftMost;

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Lives");
        rb = gameObject.GetComponent<Rigidbody2D>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentX += moveSpeed * Time.deltaTime;

        if (pingPongMovement)
        {
            if (currentX >= rightMost)
            {
                currentX = rightMost;
                moveSpeed *= -1.0f;
            }
            
            else if (currentX <= leftMost)
            {
                currentX = leftMost;
                moveSpeed *= -1.0f;
            }
        }

        else
        {
            if (currentX > rightMost)
            {
                currentX -= rightMost;
            }
            
            else if (currentX < leftMost)
            {
                currentX += rightMost;
            }
        }

        transform.position = new Vector3(currentX, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        health.GetComponent<Health>().updateHealth(0);
        Destroy(gameObject);
    }
}
