using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartHUD : MonoBehaviour
{
    public Sprite[] heartSprites;
    public Image heartUI;
    public PlayerMovement player;

    // Use this for initialization
    void Start ()
    {
        heartUI = GameObject.FindGameObjectWithTag("Hearts").GetComponent<Image>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        heartUI.sprite = heartSprites[player.lifes];

    }
}
