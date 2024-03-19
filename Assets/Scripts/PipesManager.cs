using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesManager : MonoBehaviour
{

    public GameObject pipeModel;
    public Transform spawnPoint;
    public float interval;

    private float currentTime = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > interval)
        {
            CreatePipe();
            currentTime = 0f;

        }

    }

    void CreatePipe()
    {
        Instantiate(pipeModel, spawnPoint.position, Quaternion.identity);

    }
}
