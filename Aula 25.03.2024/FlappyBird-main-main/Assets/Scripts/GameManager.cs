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

    public Bird bird;

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

    private void Update()
    {
        switch (status)
        {
            case GameStatus.Start:
                StartUpdate();
                break; 
            case GameStatus.Play:
                break; 
            case GameStatus.GameOver:
                break;

        }
    }

    private void StartUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        status = GameStatus.Play;
        bird.StartGame();
    }

    public void GameOver() 
    {
        status = GameStatus.GameOver;

    }
}
