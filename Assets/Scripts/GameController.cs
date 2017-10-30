﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        UpdateScore();   
    }

    void AddToScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    void UpdateScore()
    {        
        scoreText.text = "Score: " + score;
    }
}