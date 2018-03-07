using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamingManager : MonoBehaviour
{
    public PlayerMovement theplayer;
    public Vector3 playerStartPoint;

	// Use this for initialization
	void Start ()
    {
        playerStartPoint = theplayer.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        theplayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        theplayer.transform.position = playerStartPoint;
        theplayer.gameObject.SetActive(true);
    }
}
