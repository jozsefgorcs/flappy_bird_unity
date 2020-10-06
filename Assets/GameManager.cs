using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool IsGameRunning = false;
    public bool IsGameOver = false;

    public bool IsTouching = false;
    private int score = 0;

    [SerializeField]
    private Image tutorialImage;
    [SerializeField]
    private Image gameOverImage;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;

    void Start()
    {
        tutorialImage.gameObject.SetActive(true);
        playerRigidbody2D.bodyType = RigidbodyType2D.Static;
    }

    private void Update()
    {
        IsTouching = false;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                // Halve the size of the cube.
                IsTouching = true;
                if (IsGameOver) {
                    ReloadScene();
                }
            }

        }
        scoreText.text = score.ToString();
    }
    internal void GameOver()
    {
        IsGameRunning = false;
        IsGameOver = true;
        gameOverImage.gameObject.SetActive(true);
    }

    public void StartGame() {
        IsGameRunning = true;
        IsGameOver = false;
        tutorialImage.gameObject.SetActive(false);
        playerRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    internal void Score()
    {
        if (IsGameRunning)
        {
            score++;
        }
    }
}
