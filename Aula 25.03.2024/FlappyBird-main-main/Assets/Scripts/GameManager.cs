using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus
{
    Start,
    Play,
    GameOver
}

public class GameManager : MonoBehaviour
{    
      public static GameManager instance;

    public GameStatus status = GameStatus.Start;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }

    public void StartGame()
    {
        status = GameStatus.Play;
    }

    public void GameOver() 
    {
        status = GameStatus.GameOver;

    }
}
