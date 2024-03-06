using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpPower;
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpPower = 12;
        moveSpeed = 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpPower;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Translate(Vector2.right * moveSpeed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Translate(Vector2.left * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
