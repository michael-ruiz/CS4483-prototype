using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private GameObject health;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Lives");   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        health.GetComponent<Health>().updateHealth(1);
        Destroy(gameObject);
    }
}
