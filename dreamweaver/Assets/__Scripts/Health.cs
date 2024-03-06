using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int lives;
    private Image img;
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
        
    }

    public void updateHealth(int up)
    {
        if (up == 0)
        {
            lives -= 1;
        }

        if (up == 1)
        {
            lives += 1;
        }
        
        updateSprite();
    }

    public void updateSprite()
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
