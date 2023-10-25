using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;
    [SerializeField] private GameOverScreen _game_over_screen;
    [SerializeField] private GameOverScreen _win_screen;


    public void EndGame()
    {
        if (!isGameEnded)
        {
            isGameEnded = true;
            _game_over_screen.Setup();
        }
    }

    public void WinGame()
    {
        if (!isGameEnded)
        {
            isGameEnded = true;
            _win_screen.Setup();
        }
    }
}
