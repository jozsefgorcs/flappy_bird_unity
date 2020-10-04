using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    GameManager gameManager;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManager.IsGameRunning)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }
}
