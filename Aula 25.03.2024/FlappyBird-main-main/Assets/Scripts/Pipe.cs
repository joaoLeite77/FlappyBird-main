using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        switch (GameManager.instance.status)
        {
            case GameStatus.Start:
                break;
            case GameStatus.Play:
                PlayUpdate();
                break;
            case GameStatus.GameOver:
                break;
        }
    }
    void PlayUpdate()
    { 
       transform.position += Vector3.left * Time.deltaTime * speed;
        if (transform.position.x < -2)
        {
            // autodestruir
            Destroy(gameObject);
        }
    }
}


