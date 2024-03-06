using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 2.5f;
    private bool pingPongMovement = true;
    private float currentX;
    public float rightMost;
    public float leftMost;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
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
}
