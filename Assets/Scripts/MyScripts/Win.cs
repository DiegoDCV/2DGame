using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winMenu;
    public PlayerMovement player;
    public AudioSource winAudio;
    public ScoreManager score;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            winMenu.SetActive(true);
            player.moveSpeed = 0;
            score.scoreIncreasing = false;
            player.gameObject.SetActive(false);
            winAudio.Play();
        }
    }
}
