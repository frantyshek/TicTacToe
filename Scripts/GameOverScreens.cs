using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreens : MonoBehaviour
{

    [SerializeField] GameObject screen;

    public void PlayAgain()
    {
        var clones = GameObject.FindGameObjectsWithTag ("clone");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
        Invoke("Play", 0.05f);
    }

    public void Menu()
    {
        var clones = GameObject.FindGameObjectsWithTag ("clone");
        foreach (var clone in clones)
        {
        Destroy(clone);
        }
        Invoke("againMenu", 0.05f);
    }

    void Play()
    {
        Game.xWin = false;
        Game.oWin = false;
        Game.round = 0;
        Game.gameOver = false;
        screen.SetActive(false);
        SceneManager.LoadScene("Piskvorky");
    }

    void againMenu()
    {
        Game.xWin = false;
        Game.gameOver = false;
        Game.oWin = false;
        Game.round = 0;
        screen.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
