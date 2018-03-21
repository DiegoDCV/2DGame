using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamingManager : MonoBehaviour
{
    public PlayerMovement theplayer;
    public Vector3 playerStartPoint;
    public GameObject deadMenu;
    public MenuButtons options;

    private ScoreManager theScoreManager;

    // Use this for initialization
    void Start()
    {
        playerStartPoint = theplayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            options.PauseGame();
        }

    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.5f);
        theplayer.transform.position = playerStartPoint;
        theplayer.gameObject.SetActive(true);
        deadMenu.gameObject.SetActive(false);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

    public void Dead()
    {
        theScoreManager.scoreIncreasing = false;
        theplayer.gameObject.SetActive(false);
    }

}
