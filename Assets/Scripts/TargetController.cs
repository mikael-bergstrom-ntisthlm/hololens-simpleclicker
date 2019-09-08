using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class TargetController : MonoBehaviour, IInputClickHandler {

    private PointManager pointManager;
    private TimerController timerController;

	// Use this for initialization
	void Start () {
        pointManager = GameObject.FindGameObjectWithTag("pointcounter").GetComponent<PointManager>();
        timerController = GameObject.FindGameObjectWithTag("timer").GetComponent<TimerController>();
    }

    void Update()
    {
        if (timerController.isGameOn())
        {
            GetComponent<Collider>().enabled = true;
            GetComponent<Renderer>().enabled = true;
        }
        else
        {
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
        }
    }

    void Death()
    {
        pointManager.AddPoints(1);

        // Relocate
        Vector3 max = Camera.main.gameObject.transform.position + Vector3.one * 3;
        Vector3 min = Camera.main.gameObject.transform.position - Vector3.one * 3;

        max.z = 0.5f;
        min.z = 0.5f;

        Vector3 newPosition = new Vector3();
        newPosition.x = Random.Range(min.x, max.x);
        newPosition.y = Random.Range(min.y, max.y);
        newPosition.z = Random.Range(min.z, max.z);

        print(newPosition);

        transform.position = newPosition;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Death();
    }
}
