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


    void Start()
    {
        tutorialImage.gameObject.SetActive(true);
    
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}
