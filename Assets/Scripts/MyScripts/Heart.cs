using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public PlayerMovement player;
    public AudioSource addLife;

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
            player.AddLife(1);
            addLife.Play();
            Debug.Log("Aumenta la vida");
            gameObject.SetActive(false);
        }
    }
}
