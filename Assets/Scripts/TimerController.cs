using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour {

    

    [SerializeField]
    float maxTime = 20;

    float currentTime;

    float maxSize;

	// Use this for initialization
	void Start () {
        Reset();
        maxSize = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {

        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }

        float currentSizePart = Mathf.Max(currentTime / maxTime, 0);

        Vector3 newScale = transform.localScale;
        newScale.x = maxSize * currentSizePart;
        transform.localScale = newScale;

	}

    public void Reset()
    {
        currentTime = maxTime;
    }

    public bool isGameOn()
    {
        return currentTime > 0;
    }
}
