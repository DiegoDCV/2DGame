﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerDetection : MonoBehaviour
{
    public GameObject player;
    public GameObject dead;
	// Use this for initialization
	void Start ()
    {

		
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SetActive(false);
        dead.SetActive(true);
    }
}
