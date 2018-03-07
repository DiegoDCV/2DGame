using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public Rigidbody2D myRigidbody;
    public BoxCollider2D myCollider;

    public bool grounded;
    public LayerMask WhatIsGround;

    public Animator myAnimator;

	// Use this for initialization
	void Start ()
    {
        myRigidbody.GetComponent<Rigidbody2D>();

        myCollider.GetComponent<BoxCollider2D>();

        myAnimator.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, WhatIsGround);

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
	}
}
