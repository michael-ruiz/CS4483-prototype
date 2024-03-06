using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Level_2");
        }

        if (gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene("End");
        }
        
    }
}
