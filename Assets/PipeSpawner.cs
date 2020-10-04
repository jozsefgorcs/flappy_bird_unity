using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private  float minSpawnTime = 3f;
    [SerializeField]
    private  float maxSpawnTime = 5f;
    [SerializeField]
    private GameObject pipePrefab;
    [SerializeField]
    private GameObject spawnPosition;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Start()
    {
        StartCoroutine("Spawn");
        CreatePipe();
        
    }

    IEnumerator Spawn()
    {
        for (; ; )
        {
            // execute block of code here
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            CreatePipe();
        }
    }

    private void CreatePipe()
    {
        if (gameManager.IsGameRunning)
        {
            var go = Instantiate(pipePrefab);
            var newPos = spawnPosition.transform.position;
            newPos.y = Random.Range(-0.5f, 3);
            go.transform.position = newPos;
        }
    }
}
