using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorFades : MonoBehaviour
{
    public float currentTime;
    public float timeDuration;
    public float delayTime;
    public Color white;
    public SpriteRenderer sprite;

    // Use this for initialization
    void Start ()
    {
        sprite = GetComponent<SpriteRenderer>();
        white = GetComponent<SpriteRenderer>().color;
        currentTime = 0;
        white.a = 0.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (delayTime > 0)
        {
            delayTime -= Time.deltaTime;
            return;
        }

        if (currentTime <= timeDuration)
        {
            white.a++;

        }
        currentTime += Time.deltaTime;





    }
}
