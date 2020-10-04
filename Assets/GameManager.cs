using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool IsGameRunning = false;
    public bool IsGameOver = false;


    [SerializeField]
    private Image tutorialImage;
    [SerializeField]
    private Image gameOverImage;
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;

    void Start()
    {
        tutorialImage.gameObject.SetActive(true);
        playerRigidbody2D.bodyType = RigidbodyType2D.Static;
    }
         

    internal void GameOver()
    {
        IsGameRunning = false;
        IsGameOver = true;
    }

    public void StartGame() {
        IsGameRunning = true;
        IsGameOver = false;
        tutorialImage.gameObject.SetActive(false);
        playerRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
    }
}
