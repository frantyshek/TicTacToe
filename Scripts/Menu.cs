using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void aiOn()
    {
        Game.isAI = true;
        SceneManager.LoadScene("Piskvorky");
    }

    public void aiOff()
    {
        Game.isAI = false;
        SceneManager.LoadScene("Piskvorky");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
