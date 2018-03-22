using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesBehaviour : MonoBehaviour
{
    public GamingManager gamingManager;
    public AudioSource damageAudio;

    public PlayerMovement thePlayer;

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
        if(other.gameObject.name == "Player")
        {
            thePlayer.Damage(1);
            damageAudio.Play();
            gameObject.SetActive(false);
            Debug.Log("McQueen ha Pinchado!");
        }
    }
}
