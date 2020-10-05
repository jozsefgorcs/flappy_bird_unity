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
        var inputUp = false;
        if (gameManager.IsTouching && gameManager.IsGameRunning)
        {
            // Halve the size of the cube.
            inputUp = true;
        }

        if (Input.GetKeyDown("space") && gameManager.IsGameRunning)
        {
            inputUp = true;
        }

        if (inputUp)
        {
            rigidbody.AddForce(Vector2.up * force);
        }
    }

    private void FixedUpdate()
    {
        if (gameManager.IsGameRunning)
        {
            transform.position += transform.right * Time.deltaTime * 1;
        }
    }
    public void GameOver()
    {
        gameManager.GameOver();
    }
}
