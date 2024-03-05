using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    protected Image img;
    protected int lives;
    public Sprite life1;
    public Sprite life2;
    public Sprite life3;
    public Sprite life4;

    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<Image>();
        lives = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            lives += 1;
            updateSprite();
        }        
    }

    void updateSprite()
    {
        if (lives == 1)
        {
            img.sprite = life1;
        }

        if (lives == 2)
        {
            img.sprite = life2;
        }

        if (lives == 3)
        {
            img.sprite = life3;
        }

        if (lives == 4)
        {
            img.sprite = life4;
        }
    }
}
