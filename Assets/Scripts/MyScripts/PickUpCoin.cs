﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    public int scoreToGive;
    private ScoreManager theScoreManager;
    public AudioSource coinAudio;

	// Use this for initialization
	void Start ()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            theScoreManager.coinsCount++;
            theScoreManager.AddScore(scoreToGive);
            coinAudio.Play();
            gameObject.SetActive(false);
        }
    }
}
