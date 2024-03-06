using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void loadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
