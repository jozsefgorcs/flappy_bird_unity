using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField]
    private float force;

    GameManager gameManager;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && gameManager.IsGameRunning)
        {
            rigidbody.AddForce(Vector2.up* force);
        }
    }

    public void GameOver() {
        gameManager.GameOver();
    }
}
