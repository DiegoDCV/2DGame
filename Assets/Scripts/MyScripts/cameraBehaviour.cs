using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehaviour : MonoBehaviour
{
    public PlayerMovement thePlayer;

    private Vector3 lastPlayerPos;
    private float distanceToMove;

	// Use this for initialization
	void Start ()
    {
        thePlayer = FindObjectOfType<PlayerMovement>();
        lastPlayerPos = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        distanceToMove = thePlayer.transform.position.x - lastPlayerPos.x;
        transform.position = new Vector3(transform.position.x + distanceToMove,transform.position.y, transform.position.z);
        lastPlayerPos = thePlayer.transform.position;
		
	}
}
