using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using TMPro;

public class GameManager : MonoBehaviour, IFocusable, IInputClickHandler {

    [SerializeField]
    PointManager pointManager;

    [SerializeField]
    TextMeshPro buttonText;

    [SerializeField]
    TimerController timerController;


    [SerializeField]
    Material focusedMaterial;

    Material unfocusedMaterial;


	// Use this for initialization
	void Start () {

        unfocusedMaterial = GetComponent<Renderer>().material;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnFocusEnter()
    {
        GetComponent<Renderer>().material = focusedMaterial;
    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material = unfocusedMaterial;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        pointManager.ResetPoints();
        timerController.Reset();
    }
}
