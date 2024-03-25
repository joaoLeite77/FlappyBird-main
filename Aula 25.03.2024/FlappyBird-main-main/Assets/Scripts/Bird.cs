using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rig;
    public float jumpForce;

    void Start()
    {
        rig.bodyType = RigidbodyType2D.Static;
    }

    void Update()
    {
        switch (GameManager.instance.status)
        {
            case GameStatus.Start:
                StartUpdate();
                break;
            case GameStatus.Play:
                PlayUpdate();
                break;
            case GameStatus.GameOver:
                GameOverUpdate();
                break;
        }
    }

    void StartUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
             // GameManager.instance.status = GameStatus.Play;
             GameManager.instance.StartGame();
            rig.bodyType = RigidbodyType2D.Dynamic;
            Jump();
        }
    }

    void PlayUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void GameOverUpdate()
    {

    }

    void Jump()
    {
        rig.velocity = Vector3.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
