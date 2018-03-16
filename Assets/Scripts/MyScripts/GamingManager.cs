using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamingManager : MonoBehaviour
{
    public PlayerMovement theplayer;
    public Vector3 playerStartPoint;


    private ScoreManager theScoreManager;

	// Use this for initialization
	void Start ()
    {
        playerStartPoint = theplayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
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
        theScoreManager.scoreIncreasing = false;

        theplayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        theplayer.transform.position = playerStartPoint;
        theplayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

}
